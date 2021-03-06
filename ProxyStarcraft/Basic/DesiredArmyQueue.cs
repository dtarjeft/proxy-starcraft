﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProxyStarcraft.Basic
{
    public abstract class DesiredArmyQueue<T> : IProductionQueue where T : struct, IConvertible
    {
        Func<T, BuildingOrUnitType> buildingOrUnitTypeConverter;

        protected Dictionary<T, int> desiredUnits = new Dictionary<T, int>();

        protected DesiredArmyQueue()
        {
            if (!typeof(T).IsEnum) // enums cannot be used directly as constraints.
            {
                throw new ArgumentException($"Attempted to use {typeof(T).Name}. Can't do that.");
            }

            var convertMethods = typeof(BuildingOrUnitType)
                .GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(method => method.Name == "op_Implicit" && method.GetParameters().Any(para => para.ParameterType == typeof(T)));

            if (convertMethods == null || !convertMethods.Any())
            {
                throw new ArgumentException($"Enum {typeof(T).Name} does not convert to BuildingOrUnitType");
            }
            this.buildingOrUnitTypeConverter = (t) => (BuildingOrUnitType)convertMethods.First().Invoke(null, new object[] { (object)t }); 
        }

        public void Set(T unitType, int desired)
        {
            if (this.desiredUnits.ContainsKey(unitType))
            {
                this.desiredUnits[unitType] = desired;
            }
            else
            {
                this.desiredUnits.Add(unitType, desired);
            }
        }

        public virtual bool IsEmpty(GameState gameState)
        {
            var unitsByType = GetUnitsByType(gameState);

            return desiredUnits.All(pair => unitsByType.ContainsKey(pair.Key) && unitsByType[pair.Key] >= pair.Value);
        }

        public BuildingOrUnitType Peek(GameState gameState)
        {
            var unitsByType = GetUnitsByType(gameState);

            var nextUnitPriorities = this.desiredUnits.OrderBy(
                pair =>
                {
                    var current = unitsByType.ContainsKey(pair.Key) ? unitsByType[pair.Key] : 0;
                    var desired = pair.Value;
                    return (double)current / desired;
                }).Select(pair => pair.Key).ToList();

            if (nextUnitPriorities.Count > 0)
            {
                var nextUnitType = buildingOrUnitTypeConverter(nextUnitPriorities[0]);

                var cost = gameState.Translator.GetCost(nextUnitType);
                if (cost.IsMet(gameState) || !cost.HasResources(gameState))
                {
                    return nextUnitType;
                }
                else
                {
                    // We couldn't build this unit, but not for lack of resources, so we should expand production.
                    BuildingOrUnitType producerOrPrerequisite;

                    if (!cost.HasPrerequisite(gameState))
                    {
                        // The prerequisite could hypothetically be in progress already
                        foreach (var unit in gameState.Units)
                        {
                            if (unit.CountsAs(cost.Prerequisite) || unit.IsBuilding(cost.Prerequisite))
                            {
                                return nextUnitType;
                            }
                        }
                        
                        producerOrPrerequisite = UnitOrPrerequisite(cost.Prerequisite, gameState);
                    }
                    else
                    {
                        // At the moment the only checks are resources, prerequisite, and builder, so the builder must be missing.
                        // There is a special case where a Tech Lab prerequisite is used to enforce 'builder must have tech lab',
                        // so we might be in the position of either building an add-on or building a new instance of the building.
                        if (cost.RequiresTechLab)
                        {
                            BuildingType techLabType;
                            
                            if (cost.Builder == TerranBuildingType.Barracks)
                            {
                                techLabType = TerranBuildingType.BarracksTechLab;
                            }
                            else if (cost.Builder == TerranBuildingType.Factory)
                            {
                                techLabType = TerranBuildingType.FactoryTechLab;
                            }
                            else if (cost.Builder == TerranBuildingType.Starport)
                            {
                                techLabType = TerranBuildingType.StarportTechLab;
                            }
                            else
                            {
                                throw new NotImplementedException();
                            }

                            producerOrPrerequisite = UnitOrPrerequisite(techLabType, gameState);
                        }
                        else
                        {
                            producerOrPrerequisite = UnitOrPrerequisite(cost.Builder, gameState);
                        }
                    }

                    return producerOrPrerequisite;
                }
            }

            throw new InvalidOperationException();
        }

        public BuildingOrUnitType Pop(GameState gameState)
        {
            return Peek(gameState);
        }

        protected abstract Dictionary<T, int> GetUnitsByType(GameState gameState);

        private BuildingOrUnitType UnitOrPrerequisite(BuildingOrUnitType buildingOrUnit, GameState gameState)
        {
            var cost = gameState.Translator.GetCost(buildingOrUnit);

            if (!cost.HasPrerequisite(gameState))
            {
                return UnitOrPrerequisite(cost.Prerequisite, gameState);
            }

            return buildingOrUnit;
        }
    }
}
