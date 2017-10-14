﻿using System;

namespace ProxyStarcraft
{
    public class ZergUnit : Unit
    {
        public ZergUnit(Proto.Unit unit, Translator translator) : base(unit, translator)
        {
            var unitType = translator.GetBuildingOrUnitType(unit.UnitType);

            if (unitType.ZergUnit == ZergUnitType.Unspecified)
            {
                throw new ArgumentException($"Expected a ZergUnitType, got '{unitType.ToString()}'.");
            }

            this.ZergUnitType = unitType.ZergUnit;
        }

        public ZergUnitType ZergUnitType { get; private set; }

        public override BuildingOrUnitType Type => this.ZergUnitType;

        public BuildCommand Build(ZergBuildingType building, IBuildLocation location)
        {
            return base.Build(building, location);
        }
    }
}
