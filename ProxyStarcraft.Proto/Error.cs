// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: error.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProxyStarcraft.Proto {

  /// <summary>Holder for reflection information generated from error.proto</summary>
  public static partial class ErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtlcnJvci5wcm90bxIOU0MyQVBJUHJvdG9jb2wqwS0KDEFjdGlvblJlc3Vs",
            "dBIXChNJbnZhbGlkQWN0aW9uUmVzdWx0EAASCwoHU3VjY2VzcxABEhAKDE5v",
            "dFN1cHBvcnRlZBACEgkKBUVycm9yEAMSFgoSQ2FudFF1ZXVlVGhhdE9yZGVy",
            "EAQSCQoFUmV0cnkQBRIMCghDb29sZG93bhAGEg8KC1F1ZXVlSXNGdWxsEAcS",
            "FAoQUmFsbHlRdWV1ZUlzRnVsbBAIEhUKEU5vdEVub3VnaE1pbmVyYWxzEAkS",
            "FAoQTm90RW5vdWdoVmVzcGVuZRAKEhYKEk5vdEVub3VnaFRlcnJhemluZRAL",
            "EhMKD05vdEVub3VnaEN1c3RvbRAMEhEKDU5vdEVub3VnaEZvb2QQDRIXChNG",
            "b29kVXNhZ2VJbXBvc3NpYmxlEA4SEQoNTm90RW5vdWdoTGlmZRAPEhQKEE5v",
            "dEVub3VnaFNoaWVsZHMQEBITCg9Ob3RFbm91Z2hFbmVyZ3kQERISCg5MaWZl",
            "U3VwcHJlc3NlZBASEhUKEVNoaWVsZHNTdXBwcmVzc2VkEBMSFAoQRW5lcmd5",
            "U3VwcHJlc3NlZBAUEhQKEE5vdEVub3VnaENoYXJnZXMQFRIWChJDYW50QWRk",
            "TW9yZUNoYXJnZXMQFhITCg9Ub29NdWNoTWluZXJhbHMQFxISCg5Ub29NdWNo",
            "VmVzcGVuZRAYEhQKEFRvb011Y2hUZXJyYXppbmUQGRIRCg1Ub29NdWNoQ3Vz",
            "dG9tEBoSDwoLVG9vTXVjaEZvb2QQGxIPCgtUb29NdWNoTGlmZRAcEhIKDlRv",
            "b011Y2hTaGllbGRzEB0SEQoNVG9vTXVjaEVuZXJneRAeEhoKFk11c3RUYXJn",
            "ZXRVbml0V2l0aExpZmUQHxIdChlNdXN0VGFyZ2V0VW5pdFdpdGhTaGllbGRz",
            "ECASHAoYTXVzdFRhcmdldFVuaXRXaXRoRW5lcmd5ECESDQoJQ2FudFRyYWRl",
            "ECISDQoJQ2FudFNwZW5kECMSFgoSQ2FudFRhcmdldFRoYXRVbml0ECQSFwoT",
            "Q291bGRudEFsbG9jYXRlVW5pdBAlEhAKDFVuaXRDYW50TW92ZRAmEh4KGlRy",
            "YW5zcG9ydElzSG9sZGluZ1Bvc2l0aW9uECcSHwobQnVpbGRUZWNoUmVxdWly",
            "ZW1lbnRzTm90TWV0ECgSHQoZQ2FudEZpbmRQbGFjZW1lbnRMb2NhdGlvbhAp",
            "EhMKD0NhbnRCdWlsZE9uVGhhdBAqEh4KGkNhbnRCdWlsZFRvb0Nsb3NlVG9E",
            "cm9wT2ZmECsSHAoYQ2FudEJ1aWxkTG9jYXRpb25JbnZhbGlkECwSGAoUQ2Fu",
            "dFNlZUJ1aWxkTG9jYXRpb24QLRIiCh5DYW50QnVpbGRUb29DbG9zZVRvQ3Jl",
            "ZXBTb3VyY2UQLhIgChxDYW50QnVpbGRUb29DbG9zZVRvUmVzb3VyY2VzEC8S",
            "HAoYQ2FudEJ1aWxkVG9vRmFyRnJvbVdhdGVyEDASIgoeQ2FudEJ1aWxkVG9v",
            "RmFyRnJvbUNyZWVwU291cmNlEDESJwojQ2FudEJ1aWxkVG9vRmFyRnJvbUJ1",
            "aWxkUG93ZXJTb3VyY2UQMhIbChdDYW50QnVpbGRPbkRlbnNlVGVycmFpbhAz",
            "EicKI0NhbnRUcmFpblRvb0ZhckZyb21UcmFpblBvd2VyU291cmNlEDQSGwoX",
            "Q2FudExhbmRMb2NhdGlvbkludmFsaWQQNRIXChNDYW50U2VlTGFuZExvY2F0",
            "aW9uEDYSIQodQ2FudExhbmRUb29DbG9zZVRvQ3JlZXBTb3VyY2UQNxIfChtD",
            "YW50TGFuZFRvb0Nsb3NlVG9SZXNvdXJjZXMQOBIbChdDYW50TGFuZFRvb0Zh",
            "ckZyb21XYXRlchA5EiEKHUNhbnRMYW5kVG9vRmFyRnJvbUNyZWVwU291cmNl",
            "EDoSJgoiQ2FudExhbmRUb29GYXJGcm9tQnVpbGRQb3dlclNvdXJjZRA7EiYK",
            "IkNhbnRMYW5kVG9vRmFyRnJvbVRyYWluUG93ZXJTb3VyY2UQPBIaChZDYW50",
            "TGFuZE9uRGVuc2VUZXJyYWluED0SGwoXQWRkT25Ub29GYXJGcm9tQnVpbGRp",
            "bmcQPhIaChZNdXN0QnVpbGRSZWZpbmVyeUZpcnN0ED8SHwobQnVpbGRpbmdJ",
            "c1VuZGVyQ29uc3RydWN0aW9uEEASEwoPQ2FudEZpbmREcm9wT2ZmEEESHQoZ",
            "Q2FudExvYWRPdGhlclBsYXllcnNVbml0cxBCEhsKF05vdEVub3VnaFJvb21U",
            "b0xvYWRVbml0EEMSGAoUQ2FudFVubG9hZFVuaXRzVGhlcmUQRBIYChRDYW50",
            "V2FycEluVW5pdHNUaGVyZRBFEhkKFUNhbnRMb2FkSW1tb2JpbGVVbml0cxBG",
            "Eh0KGUNhbnRSZWNoYXJnZUltbW9iaWxlVW5pdHMQRxImCiJDYW50UmVjaGFy",
            "Z2VVbmRlckNvbnN0cnVjdGlvblVuaXRzEEgSFAoQQ2FudExvYWRUaGF0VW5p",
            "dBBJEhMKD05vQ2FyZ29Ub1VubG9hZBBKEhkKFUxvYWRBbGxOb1RhcmdldHNG",
            "b3VuZBBLEhQKEE5vdFdoaWxlT2NjdXBpZWQQTBIZChVDYW50QXR0YWNrV2l0",
            "aG91dEFtbW8QTRIXChNDYW50SG9sZEFueU1vcmVBbW1vEE4SGgoWVGVjaFJl",
            "cXVpcmVtZW50c05vdE1ldBBPEhkKFU11c3RMb2NrZG93blVuaXRGaXJzdBBQ",
            "EhIKDk11c3RUYXJnZXRVbml0EFESFwoTTXVzdFRhcmdldEludmVudG9yeRBS",
            "EhkKFU11c3RUYXJnZXRWaXNpYmxlVW5pdBBTEh0KGU11c3RUYXJnZXRWaXNp",
            "YmxlTG9jYXRpb24QVBIeChpNdXN0VGFyZ2V0V2Fsa2FibGVMb2NhdGlvbhBV",
            "EhoKFk11c3RUYXJnZXRQYXduYWJsZVVuaXQQVhIaChZZb3VDYW50Q29udHJv",
            "bFRoYXRVbml0EFcSIgoeWW91Q2FudElzc3VlQ29tbWFuZHNUb1RoYXRVbml0",
            "EFgSFwoTTXVzdFRhcmdldFJlc291cmNlcxBZEhYKElJlcXVpcmVzSGVhbFRh",
            "cmdldBBaEhgKFFJlcXVpcmVzUmVwYWlyVGFyZ2V0EFsSEQoNTm9JdGVtc1Rv",
            "RHJvcBBcEhgKFENhbnRIb2xkQW55TW9yZUl0ZW1zEF0SEAoMQ2FudEhvbGRU",
            "aGF0EF4SGAoUVGFyZ2V0SGFzTm9JbnZlbnRvcnkQXxIUChBDYW50RHJvcFRo",
            "aXNJdGVtEGASFAoQQ2FudE1vdmVUaGlzSXRlbRBhEhQKEENhbnRQYXduVGhp",
            "c1VuaXQQYhIUChBNdXN0VGFyZ2V0Q2FzdGVyEGMSFAoQQ2FudFRhcmdldENh",
            "c3RlchBkEhMKD011c3RUYXJnZXRPdXRlchBlEhMKD0NhbnRUYXJnZXRPdXRl",
            "chBmEhoKFk11c3RUYXJnZXRZb3VyT3duVW5pdHMQZxIaChZDYW50VGFyZ2V0",
            "WW91ck93blVuaXRzEGgSGwoXTXVzdFRhcmdldEZyaWVuZGx5VW5pdHMQaRIb",
            "ChdDYW50VGFyZ2V0RnJpZW5kbHlVbml0cxBqEhoKFk11c3RUYXJnZXROZXV0",
            "cmFsVW5pdHMQaxIaChZDYW50VGFyZ2V0TmV1dHJhbFVuaXRzEGwSGAoUTXVz",
            "dFRhcmdldEVuZW15VW5pdHMQbRIYChRDYW50VGFyZ2V0RW5lbXlVbml0cxBu",
            "EhYKEk11c3RUYXJnZXRBaXJVbml0cxBvEhYKEkNhbnRUYXJnZXRBaXJVbml0",
            "cxBwEhkKFU11c3RUYXJnZXRHcm91bmRVbml0cxBxEhkKFUNhbnRUYXJnZXRH",
            "cm91bmRVbml0cxByEhgKFE11c3RUYXJnZXRTdHJ1Y3R1cmVzEHMSGAoUQ2Fu",
            "dFRhcmdldFN0cnVjdHVyZXMQdBIYChRNdXN0VGFyZ2V0TGlnaHRVbml0cxB1",
            "EhgKFENhbnRUYXJnZXRMaWdodFVuaXRzEHYSGgoWTXVzdFRhcmdldEFybW9y",
            "ZWRVbml0cxB3EhoKFkNhbnRUYXJnZXRBcm1vcmVkVW5pdHMQeBIdChlNdXN0",
            "VGFyZ2V0QmlvbG9naWNhbFVuaXRzEHkSHQoZQ2FudFRhcmdldEJpb2xvZ2lj",
            "YWxVbml0cxB6EhkKFU11c3RUYXJnZXRIZXJvaWNVbml0cxB7EhkKFUNhbnRU",
            "YXJnZXRIZXJvaWNVbml0cxB8EhoKFk11c3RUYXJnZXRSb2JvdGljVW5pdHMQ",
            "fRIaChZDYW50VGFyZ2V0Um9ib3RpY1VuaXRzEH4SHQoZTXVzdFRhcmdldE1l",
            "Y2hhbmljYWxVbml0cxB/Eh4KGUNhbnRUYXJnZXRNZWNoYW5pY2FsVW5pdHMQ",
            "gAESGwoWTXVzdFRhcmdldFBzaW9uaWNVbml0cxCBARIbChZDYW50VGFyZ2V0",
            "UHNpb25pY1VuaXRzEIIBEhsKFk11c3RUYXJnZXRNYXNzaXZlVW5pdHMQgwES",
            "GwoWQ2FudFRhcmdldE1hc3NpdmVVbml0cxCEARIWChFNdXN0VGFyZ2V0TWlz",
            "c2lsZRCFARIWChFDYW50VGFyZ2V0TWlzc2lsZRCGARIaChVNdXN0VGFyZ2V0",
            "V29ya2VyVW5pdHMQhwESGgoVQ2FudFRhcmdldFdvcmtlclVuaXRzEIgBEiEK",
            "HE11c3RUYXJnZXRFbmVyZ3lDYXBhYmxlVW5pdHMQiQESIQocQ2FudFRhcmdl",
            "dEVuZXJneUNhcGFibGVVbml0cxCKARIhChxNdXN0VGFyZ2V0U2hpZWxkQ2Fw",
            "YWJsZVVuaXRzEIsBEiEKHENhbnRUYXJnZXRTaGllbGRDYXBhYmxlVW5pdHMQ",
            "jAESFQoQTXVzdFRhcmdldEZseWVycxCNARIVChBDYW50VGFyZ2V0Rmx5ZXJz",
            "EI4BEhoKFU11c3RUYXJnZXRCdXJpZWRVbml0cxCPARIaChVDYW50VGFyZ2V0",
            "QnVyaWVkVW5pdHMQkAESGwoWTXVzdFRhcmdldENsb2FrZWRVbml0cxCRARIb",
            "ChZDYW50VGFyZ2V0Q2xvYWtlZFVuaXRzEJIBEiIKHU11c3RUYXJnZXRVbml0",
            "c0luQVN0YXNpc0ZpZWxkEJMBEiIKHUNhbnRUYXJnZXRVbml0c0luQVN0YXNp",
            "c0ZpZWxkEJQBEiUKIE11c3RUYXJnZXRVbmRlckNvbnN0cnVjdGlvblVuaXRz",
            "EJUBEiUKIENhbnRUYXJnZXRVbmRlckNvbnN0cnVjdGlvblVuaXRzEJYBEhgK",
            "E011c3RUYXJnZXREZWFkVW5pdHMQlwESGAoTQ2FudFRhcmdldERlYWRVbml0",
            "cxCYARIdChhNdXN0VGFyZ2V0UmV2aXZhYmxlVW5pdHMQmQESHQoYQ2FudFRh",
            "cmdldFJldml2YWJsZVVuaXRzEJoBEhoKFU11c3RUYXJnZXRIaWRkZW5Vbml0",
            "cxCbARIaChVDYW50VGFyZ2V0SGlkZGVuVW5pdHMQnAESIgodQ2FudFJlY2hh",
            "cmdlT3RoZXJQbGF5ZXJzVW5pdHMQnQESHQoYTXVzdFRhcmdldEhhbGx1Y2lu",
            "YXRpb25zEJ4BEh0KGENhbnRUYXJnZXRIYWxsdWNpbmF0aW9ucxCfARIgChtN",
            "dXN0VGFyZ2V0SW52dWxuZXJhYmxlVW5pdHMQoAESIAobQ2FudFRhcmdldElu",
            "dnVsbmVyYWJsZVVuaXRzEKEBEhwKF011c3RUYXJnZXREZXRlY3RlZFVuaXRz",
            "EKIBEhwKF0NhbnRUYXJnZXREZXRlY3RlZFVuaXRzEKMBEh0KGENhbnRUYXJn",
            "ZXRVbml0V2l0aEVuZXJneRCkARIeChlDYW50VGFyZ2V0VW5pdFdpdGhTaGll",
            "bGRzEKUBEiEKHE11c3RUYXJnZXRVbmNvbW1hbmRhYmxlVW5pdHMQpgESIQoc",
            "Q2FudFRhcmdldFVuY29tbWFuZGFibGVVbml0cxCnARIhChxNdXN0VGFyZ2V0",
            "UHJldmVudERlZmVhdFVuaXRzEKgBEiEKHENhbnRUYXJnZXRQcmV2ZW50RGVm",
            "ZWF0VW5pdHMQqQESIQocTXVzdFRhcmdldFByZXZlbnRSZXZlYWxVbml0cxCq",
            "ARIhChxDYW50VGFyZ2V0UHJldmVudFJldmVhbFVuaXRzEKsBEhsKFk11c3RU",
            "YXJnZXRQYXNzaXZlVW5pdHMQrAESGwoWQ2FudFRhcmdldFBhc3NpdmVVbml0",
            "cxCtARIbChZNdXN0VGFyZ2V0U3R1bm5lZFVuaXRzEK4BEhsKFkNhbnRUYXJn",
            "ZXRTdHVubmVkVW5pdHMQrwESHAoXTXVzdFRhcmdldFN1bW1vbmVkVW5pdHMQ",
            "sAESHAoXQ2FudFRhcmdldFN1bW1vbmVkVW5pdHMQsQESFAoPTXVzdFRhcmdl",
            "dFVzZXIxELIBEhQKD0NhbnRUYXJnZXRVc2VyMRCzARIfChpNdXN0VGFyZ2V0",
            "VW5zdG9wcGFibGVVbml0cxC0ARIfChpDYW50VGFyZ2V0VW5zdG9wcGFibGVV",
            "bml0cxC1ARIdChhNdXN0VGFyZ2V0UmVzaXN0YW50VW5pdHMQtgESHQoYQ2Fu",
            "dFRhcmdldFJlc2lzdGFudFVuaXRzELcBEhkKFE11c3RUYXJnZXREYXplZFVu",
            "aXRzELgBEhkKFENhbnRUYXJnZXREYXplZFVuaXRzELkBEhEKDENhbnRMb2Nr",
            "ZG93bhC6ARIUCg9DYW50TWluZENvbnRyb2wQuwESHAoXTXVzdFRhcmdldERl",
            "c3RydWN0aWJsZXMQvAESHAoXQ2FudFRhcmdldERlc3RydWN0aWJsZXMQvQES",
            "FAoPTXVzdFRhcmdldEl0ZW1zEL4BEhQKD0NhbnRUYXJnZXRJdGVtcxC/ARIY",
            "ChNOb0NhbGxkb3duQXZhaWxhYmxlEMABEhUKEFdheXBvaW50TGlzdEZ1bGwQ",
            "wQESEwoOTXVzdFRhcmdldFJhY2UQwgESEwoOQ2FudFRhcmdldFJhY2UQwwES",
            "GwoWTXVzdFRhcmdldFNpbWlsYXJVbml0cxDEARIbChZDYW50VGFyZ2V0U2lt",
            "aWxhclVuaXRzEMUBEhoKFUNhbnRGaW5kRW5vdWdoVGFyZ2V0cxDGARIZChRB",
            "bHJlYWR5U3Bhd25pbmdMYXJ2YRDHARIhChxDYW50VGFyZ2V0RXhoYXVzdGVk",
            "UmVzb3VyY2VzEMgBEhMKDkNhbnRVc2VNaW5pbWFwEMkBEhUKEENhbnRVc2VJ",
            "bmZvUGFuZWwQygESFQoQT3JkZXJRdWV1ZUlzRnVsbBDLARIcChdDYW50SGFy",
            "dmVzdFRoYXRSZXNvdXJjZRDMARIaChVIYXJ2ZXN0ZXJzTm90UmVxdWlyZWQQ",
            "zQESFAoPQWxyZWFkeVRhcmdldGVkEM4BEh4KGUNhbnRBdHRhY2tXZWFwb25z",
            "RGlzYWJsZWQQzwESFwoSQ291bGRudFJlYWNoVGFyZ2V0ENABEhcKElRhcmdl",
            "dElzT3V0T2ZSYW5nZRDRARIVChBUYXJnZXRJc1Rvb0Nsb3NlENIBEhUKEFRh",
            "cmdldElzT3V0T2ZBcmMQ0wESHQoYQ2FudEZpbmRUZWxlcG9ydExvY2F0aW9u",
            "ENQBEhUKEEludmFsaWRJdGVtQ2xhc3MQ1QESGAoTQ2FudEZpbmRDYW5jZWxP",
            "cmRlchDWAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::SC2APIProtocol.ActionResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ActionResult {
    [pbr::OriginalName("InvalidActionResult")] InvalidActionResult = 0,
    [pbr::OriginalName("Success")] Success = 1,
    [pbr::OriginalName("NotSupported")] NotSupported = 2,
    [pbr::OriginalName("Error")] Error = 3,
    [pbr::OriginalName("CantQueueThatOrder")] CantQueueThatOrder = 4,
    [pbr::OriginalName("Retry")] Retry = 5,
    [pbr::OriginalName("Cooldown")] Cooldown = 6,
    [pbr::OriginalName("QueueIsFull")] QueueIsFull = 7,
    [pbr::OriginalName("RallyQueueIsFull")] RallyQueueIsFull = 8,
    [pbr::OriginalName("NotEnoughMinerals")] NotEnoughMinerals = 9,
    [pbr::OriginalName("NotEnoughVespene")] NotEnoughVespene = 10,
    [pbr::OriginalName("NotEnoughTerrazine")] NotEnoughTerrazine = 11,
    [pbr::OriginalName("NotEnoughCustom")] NotEnoughCustom = 12,
    [pbr::OriginalName("NotEnoughFood")] NotEnoughFood = 13,
    [pbr::OriginalName("FoodUsageImpossible")] FoodUsageImpossible = 14,
    [pbr::OriginalName("NotEnoughLife")] NotEnoughLife = 15,
    [pbr::OriginalName("NotEnoughShields")] NotEnoughShields = 16,
    [pbr::OriginalName("NotEnoughEnergy")] NotEnoughEnergy = 17,
    [pbr::OriginalName("LifeSuppressed")] LifeSuppressed = 18,
    [pbr::OriginalName("ShieldsSuppressed")] ShieldsSuppressed = 19,
    [pbr::OriginalName("EnergySuppressed")] EnergySuppressed = 20,
    [pbr::OriginalName("NotEnoughCharges")] NotEnoughCharges = 21,
    [pbr::OriginalName("CantAddMoreCharges")] CantAddMoreCharges = 22,
    [pbr::OriginalName("TooMuchMinerals")] TooMuchMinerals = 23,
    [pbr::OriginalName("TooMuchVespene")] TooMuchVespene = 24,
    [pbr::OriginalName("TooMuchTerrazine")] TooMuchTerrazine = 25,
    [pbr::OriginalName("TooMuchCustom")] TooMuchCustom = 26,
    [pbr::OriginalName("TooMuchFood")] TooMuchFood = 27,
    [pbr::OriginalName("TooMuchLife")] TooMuchLife = 28,
    [pbr::OriginalName("TooMuchShields")] TooMuchShields = 29,
    [pbr::OriginalName("TooMuchEnergy")] TooMuchEnergy = 30,
    [pbr::OriginalName("MustTargetUnitWithLife")] MustTargetUnitWithLife = 31,
    [pbr::OriginalName("MustTargetUnitWithShields")] MustTargetUnitWithShields = 32,
    [pbr::OriginalName("MustTargetUnitWithEnergy")] MustTargetUnitWithEnergy = 33,
    [pbr::OriginalName("CantTrade")] CantTrade = 34,
    [pbr::OriginalName("CantSpend")] CantSpend = 35,
    [pbr::OriginalName("CantTargetThatUnit")] CantTargetThatUnit = 36,
    [pbr::OriginalName("CouldntAllocateUnit")] CouldntAllocateUnit = 37,
    [pbr::OriginalName("UnitCantMove")] UnitCantMove = 38,
    [pbr::OriginalName("TransportIsHoldingPosition")] TransportIsHoldingPosition = 39,
    [pbr::OriginalName("BuildTechRequirementsNotMet")] BuildTechRequirementsNotMet = 40,
    [pbr::OriginalName("CantFindPlacementLocation")] CantFindPlacementLocation = 41,
    [pbr::OriginalName("CantBuildOnThat")] CantBuildOnThat = 42,
    [pbr::OriginalName("CantBuildTooCloseToDropOff")] CantBuildTooCloseToDropOff = 43,
    [pbr::OriginalName("CantBuildLocationInvalid")] CantBuildLocationInvalid = 44,
    [pbr::OriginalName("CantSeeBuildLocation")] CantSeeBuildLocation = 45,
    [pbr::OriginalName("CantBuildTooCloseToCreepSource")] CantBuildTooCloseToCreepSource = 46,
    [pbr::OriginalName("CantBuildTooCloseToResources")] CantBuildTooCloseToResources = 47,
    [pbr::OriginalName("CantBuildTooFarFromWater")] CantBuildTooFarFromWater = 48,
    [pbr::OriginalName("CantBuildTooFarFromCreepSource")] CantBuildTooFarFromCreepSource = 49,
    [pbr::OriginalName("CantBuildTooFarFromBuildPowerSource")] CantBuildTooFarFromBuildPowerSource = 50,
    [pbr::OriginalName("CantBuildOnDenseTerrain")] CantBuildOnDenseTerrain = 51,
    [pbr::OriginalName("CantTrainTooFarFromTrainPowerSource")] CantTrainTooFarFromTrainPowerSource = 52,
    [pbr::OriginalName("CantLandLocationInvalid")] CantLandLocationInvalid = 53,
    [pbr::OriginalName("CantSeeLandLocation")] CantSeeLandLocation = 54,
    [pbr::OriginalName("CantLandTooCloseToCreepSource")] CantLandTooCloseToCreepSource = 55,
    [pbr::OriginalName("CantLandTooCloseToResources")] CantLandTooCloseToResources = 56,
    [pbr::OriginalName("CantLandTooFarFromWater")] CantLandTooFarFromWater = 57,
    [pbr::OriginalName("CantLandTooFarFromCreepSource")] CantLandTooFarFromCreepSource = 58,
    [pbr::OriginalName("CantLandTooFarFromBuildPowerSource")] CantLandTooFarFromBuildPowerSource = 59,
    [pbr::OriginalName("CantLandTooFarFromTrainPowerSource")] CantLandTooFarFromTrainPowerSource = 60,
    [pbr::OriginalName("CantLandOnDenseTerrain")] CantLandOnDenseTerrain = 61,
    [pbr::OriginalName("AddOnTooFarFromBuilding")] AddOnTooFarFromBuilding = 62,
    [pbr::OriginalName("MustBuildRefineryFirst")] MustBuildRefineryFirst = 63,
    [pbr::OriginalName("BuildingIsUnderConstruction")] BuildingIsUnderConstruction = 64,
    [pbr::OriginalName("CantFindDropOff")] CantFindDropOff = 65,
    [pbr::OriginalName("CantLoadOtherPlayersUnits")] CantLoadOtherPlayersUnits = 66,
    [pbr::OriginalName("NotEnoughRoomToLoadUnit")] NotEnoughRoomToLoadUnit = 67,
    [pbr::OriginalName("CantUnloadUnitsThere")] CantUnloadUnitsThere = 68,
    [pbr::OriginalName("CantWarpInUnitsThere")] CantWarpInUnitsThere = 69,
    [pbr::OriginalName("CantLoadImmobileUnits")] CantLoadImmobileUnits = 70,
    [pbr::OriginalName("CantRechargeImmobileUnits")] CantRechargeImmobileUnits = 71,
    [pbr::OriginalName("CantRechargeUnderConstructionUnits")] CantRechargeUnderConstructionUnits = 72,
    [pbr::OriginalName("CantLoadThatUnit")] CantLoadThatUnit = 73,
    [pbr::OriginalName("NoCargoToUnload")] NoCargoToUnload = 74,
    [pbr::OriginalName("LoadAllNoTargetsFound")] LoadAllNoTargetsFound = 75,
    [pbr::OriginalName("NotWhileOccupied")] NotWhileOccupied = 76,
    [pbr::OriginalName("CantAttackWithoutAmmo")] CantAttackWithoutAmmo = 77,
    [pbr::OriginalName("CantHoldAnyMoreAmmo")] CantHoldAnyMoreAmmo = 78,
    [pbr::OriginalName("TechRequirementsNotMet")] TechRequirementsNotMet = 79,
    [pbr::OriginalName("MustLockdownUnitFirst")] MustLockdownUnitFirst = 80,
    [pbr::OriginalName("MustTargetUnit")] MustTargetUnit = 81,
    [pbr::OriginalName("MustTargetInventory")] MustTargetInventory = 82,
    [pbr::OriginalName("MustTargetVisibleUnit")] MustTargetVisibleUnit = 83,
    [pbr::OriginalName("MustTargetVisibleLocation")] MustTargetVisibleLocation = 84,
    [pbr::OriginalName("MustTargetWalkableLocation")] MustTargetWalkableLocation = 85,
    [pbr::OriginalName("MustTargetPawnableUnit")] MustTargetPawnableUnit = 86,
    [pbr::OriginalName("YouCantControlThatUnit")] YouCantControlThatUnit = 87,
    [pbr::OriginalName("YouCantIssueCommandsToThatUnit")] YouCantIssueCommandsToThatUnit = 88,
    [pbr::OriginalName("MustTargetResources")] MustTargetResources = 89,
    [pbr::OriginalName("RequiresHealTarget")] RequiresHealTarget = 90,
    [pbr::OriginalName("RequiresRepairTarget")] RequiresRepairTarget = 91,
    [pbr::OriginalName("NoItemsToDrop")] NoItemsToDrop = 92,
    [pbr::OriginalName("CantHoldAnyMoreItems")] CantHoldAnyMoreItems = 93,
    [pbr::OriginalName("CantHoldThat")] CantHoldThat = 94,
    [pbr::OriginalName("TargetHasNoInventory")] TargetHasNoInventory = 95,
    [pbr::OriginalName("CantDropThisItem")] CantDropThisItem = 96,
    [pbr::OriginalName("CantMoveThisItem")] CantMoveThisItem = 97,
    [pbr::OriginalName("CantPawnThisUnit")] CantPawnThisUnit = 98,
    [pbr::OriginalName("MustTargetCaster")] MustTargetCaster = 99,
    [pbr::OriginalName("CantTargetCaster")] CantTargetCaster = 100,
    [pbr::OriginalName("MustTargetOuter")] MustTargetOuter = 101,
    [pbr::OriginalName("CantTargetOuter")] CantTargetOuter = 102,
    [pbr::OriginalName("MustTargetYourOwnUnits")] MustTargetYourOwnUnits = 103,
    [pbr::OriginalName("CantTargetYourOwnUnits")] CantTargetYourOwnUnits = 104,
    [pbr::OriginalName("MustTargetFriendlyUnits")] MustTargetFriendlyUnits = 105,
    [pbr::OriginalName("CantTargetFriendlyUnits")] CantTargetFriendlyUnits = 106,
    [pbr::OriginalName("MustTargetNeutralUnits")] MustTargetNeutralUnits = 107,
    [pbr::OriginalName("CantTargetNeutralUnits")] CantTargetNeutralUnits = 108,
    [pbr::OriginalName("MustTargetEnemyUnits")] MustTargetEnemyUnits = 109,
    [pbr::OriginalName("CantTargetEnemyUnits")] CantTargetEnemyUnits = 110,
    [pbr::OriginalName("MustTargetAirUnits")] MustTargetAirUnits = 111,
    [pbr::OriginalName("CantTargetAirUnits")] CantTargetAirUnits = 112,
    [pbr::OriginalName("MustTargetGroundUnits")] MustTargetGroundUnits = 113,
    [pbr::OriginalName("CantTargetGroundUnits")] CantTargetGroundUnits = 114,
    [pbr::OriginalName("MustTargetStructures")] MustTargetStructures = 115,
    [pbr::OriginalName("CantTargetStructures")] CantTargetStructures = 116,
    [pbr::OriginalName("MustTargetLightUnits")] MustTargetLightUnits = 117,
    [pbr::OriginalName("CantTargetLightUnits")] CantTargetLightUnits = 118,
    [pbr::OriginalName("MustTargetArmoredUnits")] MustTargetArmoredUnits = 119,
    [pbr::OriginalName("CantTargetArmoredUnits")] CantTargetArmoredUnits = 120,
    [pbr::OriginalName("MustTargetBiologicalUnits")] MustTargetBiologicalUnits = 121,
    [pbr::OriginalName("CantTargetBiologicalUnits")] CantTargetBiologicalUnits = 122,
    [pbr::OriginalName("MustTargetHeroicUnits")] MustTargetHeroicUnits = 123,
    [pbr::OriginalName("CantTargetHeroicUnits")] CantTargetHeroicUnits = 124,
    [pbr::OriginalName("MustTargetRoboticUnits")] MustTargetRoboticUnits = 125,
    [pbr::OriginalName("CantTargetRoboticUnits")] CantTargetRoboticUnits = 126,
    [pbr::OriginalName("MustTargetMechanicalUnits")] MustTargetMechanicalUnits = 127,
    [pbr::OriginalName("CantTargetMechanicalUnits")] CantTargetMechanicalUnits = 128,
    [pbr::OriginalName("MustTargetPsionicUnits")] MustTargetPsionicUnits = 129,
    [pbr::OriginalName("CantTargetPsionicUnits")] CantTargetPsionicUnits = 130,
    [pbr::OriginalName("MustTargetMassiveUnits")] MustTargetMassiveUnits = 131,
    [pbr::OriginalName("CantTargetMassiveUnits")] CantTargetMassiveUnits = 132,
    [pbr::OriginalName("MustTargetMissile")] MustTargetMissile = 133,
    [pbr::OriginalName("CantTargetMissile")] CantTargetMissile = 134,
    [pbr::OriginalName("MustTargetWorkerUnits")] MustTargetWorkerUnits = 135,
    [pbr::OriginalName("CantTargetWorkerUnits")] CantTargetWorkerUnits = 136,
    [pbr::OriginalName("MustTargetEnergyCapableUnits")] MustTargetEnergyCapableUnits = 137,
    [pbr::OriginalName("CantTargetEnergyCapableUnits")] CantTargetEnergyCapableUnits = 138,
    [pbr::OriginalName("MustTargetShieldCapableUnits")] MustTargetShieldCapableUnits = 139,
    [pbr::OriginalName("CantTargetShieldCapableUnits")] CantTargetShieldCapableUnits = 140,
    [pbr::OriginalName("MustTargetFlyers")] MustTargetFlyers = 141,
    [pbr::OriginalName("CantTargetFlyers")] CantTargetFlyers = 142,
    [pbr::OriginalName("MustTargetBuriedUnits")] MustTargetBuriedUnits = 143,
    [pbr::OriginalName("CantTargetBuriedUnits")] CantTargetBuriedUnits = 144,
    [pbr::OriginalName("MustTargetCloakedUnits")] MustTargetCloakedUnits = 145,
    [pbr::OriginalName("CantTargetCloakedUnits")] CantTargetCloakedUnits = 146,
    [pbr::OriginalName("MustTargetUnitsInAStasisField")] MustTargetUnitsInAstasisField = 147,
    [pbr::OriginalName("CantTargetUnitsInAStasisField")] CantTargetUnitsInAstasisField = 148,
    [pbr::OriginalName("MustTargetUnderConstructionUnits")] MustTargetUnderConstructionUnits = 149,
    [pbr::OriginalName("CantTargetUnderConstructionUnits")] CantTargetUnderConstructionUnits = 150,
    [pbr::OriginalName("MustTargetDeadUnits")] MustTargetDeadUnits = 151,
    [pbr::OriginalName("CantTargetDeadUnits")] CantTargetDeadUnits = 152,
    [pbr::OriginalName("MustTargetRevivableUnits")] MustTargetRevivableUnits = 153,
    [pbr::OriginalName("CantTargetRevivableUnits")] CantTargetRevivableUnits = 154,
    [pbr::OriginalName("MustTargetHiddenUnits")] MustTargetHiddenUnits = 155,
    [pbr::OriginalName("CantTargetHiddenUnits")] CantTargetHiddenUnits = 156,
    [pbr::OriginalName("CantRechargeOtherPlayersUnits")] CantRechargeOtherPlayersUnits = 157,
    [pbr::OriginalName("MustTargetHallucinations")] MustTargetHallucinations = 158,
    [pbr::OriginalName("CantTargetHallucinations")] CantTargetHallucinations = 159,
    [pbr::OriginalName("MustTargetInvulnerableUnits")] MustTargetInvulnerableUnits = 160,
    [pbr::OriginalName("CantTargetInvulnerableUnits")] CantTargetInvulnerableUnits = 161,
    [pbr::OriginalName("MustTargetDetectedUnits")] MustTargetDetectedUnits = 162,
    [pbr::OriginalName("CantTargetDetectedUnits")] CantTargetDetectedUnits = 163,
    [pbr::OriginalName("CantTargetUnitWithEnergy")] CantTargetUnitWithEnergy = 164,
    [pbr::OriginalName("CantTargetUnitWithShields")] CantTargetUnitWithShields = 165,
    [pbr::OriginalName("MustTargetUncommandableUnits")] MustTargetUncommandableUnits = 166,
    [pbr::OriginalName("CantTargetUncommandableUnits")] CantTargetUncommandableUnits = 167,
    [pbr::OriginalName("MustTargetPreventDefeatUnits")] MustTargetPreventDefeatUnits = 168,
    [pbr::OriginalName("CantTargetPreventDefeatUnits")] CantTargetPreventDefeatUnits = 169,
    [pbr::OriginalName("MustTargetPreventRevealUnits")] MustTargetPreventRevealUnits = 170,
    [pbr::OriginalName("CantTargetPreventRevealUnits")] CantTargetPreventRevealUnits = 171,
    [pbr::OriginalName("MustTargetPassiveUnits")] MustTargetPassiveUnits = 172,
    [pbr::OriginalName("CantTargetPassiveUnits")] CantTargetPassiveUnits = 173,
    [pbr::OriginalName("MustTargetStunnedUnits")] MustTargetStunnedUnits = 174,
    [pbr::OriginalName("CantTargetStunnedUnits")] CantTargetStunnedUnits = 175,
    [pbr::OriginalName("MustTargetSummonedUnits")] MustTargetSummonedUnits = 176,
    [pbr::OriginalName("CantTargetSummonedUnits")] CantTargetSummonedUnits = 177,
    [pbr::OriginalName("MustTargetUser1")] MustTargetUser1 = 178,
    [pbr::OriginalName("CantTargetUser1")] CantTargetUser1 = 179,
    [pbr::OriginalName("MustTargetUnstoppableUnits")] MustTargetUnstoppableUnits = 180,
    [pbr::OriginalName("CantTargetUnstoppableUnits")] CantTargetUnstoppableUnits = 181,
    [pbr::OriginalName("MustTargetResistantUnits")] MustTargetResistantUnits = 182,
    [pbr::OriginalName("CantTargetResistantUnits")] CantTargetResistantUnits = 183,
    [pbr::OriginalName("MustTargetDazedUnits")] MustTargetDazedUnits = 184,
    [pbr::OriginalName("CantTargetDazedUnits")] CantTargetDazedUnits = 185,
    [pbr::OriginalName("CantLockdown")] CantLockdown = 186,
    [pbr::OriginalName("CantMindControl")] CantMindControl = 187,
    [pbr::OriginalName("MustTargetDestructibles")] MustTargetDestructibles = 188,
    [pbr::OriginalName("CantTargetDestructibles")] CantTargetDestructibles = 189,
    [pbr::OriginalName("MustTargetItems")] MustTargetItems = 190,
    [pbr::OriginalName("CantTargetItems")] CantTargetItems = 191,
    [pbr::OriginalName("NoCalldownAvailable")] NoCalldownAvailable = 192,
    [pbr::OriginalName("WaypointListFull")] WaypointListFull = 193,
    [pbr::OriginalName("MustTargetRace")] MustTargetRace = 194,
    [pbr::OriginalName("CantTargetRace")] CantTargetRace = 195,
    [pbr::OriginalName("MustTargetSimilarUnits")] MustTargetSimilarUnits = 196,
    [pbr::OriginalName("CantTargetSimilarUnits")] CantTargetSimilarUnits = 197,
    [pbr::OriginalName("CantFindEnoughTargets")] CantFindEnoughTargets = 198,
    [pbr::OriginalName("AlreadySpawningLarva")] AlreadySpawningLarva = 199,
    [pbr::OriginalName("CantTargetExhaustedResources")] CantTargetExhaustedResources = 200,
    [pbr::OriginalName("CantUseMinimap")] CantUseMinimap = 201,
    [pbr::OriginalName("CantUseInfoPanel")] CantUseInfoPanel = 202,
    [pbr::OriginalName("OrderQueueIsFull")] OrderQueueIsFull = 203,
    [pbr::OriginalName("CantHarvestThatResource")] CantHarvestThatResource = 204,
    [pbr::OriginalName("HarvestersNotRequired")] HarvestersNotRequired = 205,
    [pbr::OriginalName("AlreadyTargeted")] AlreadyTargeted = 206,
    [pbr::OriginalName("CantAttackWeaponsDisabled")] CantAttackWeaponsDisabled = 207,
    [pbr::OriginalName("CouldntReachTarget")] CouldntReachTarget = 208,
    [pbr::OriginalName("TargetIsOutOfRange")] TargetIsOutOfRange = 209,
    [pbr::OriginalName("TargetIsTooClose")] TargetIsTooClose = 210,
    [pbr::OriginalName("TargetIsOutOfArc")] TargetIsOutOfArc = 211,
    [pbr::OriginalName("CantFindTeleportLocation")] CantFindTeleportLocation = 212,
    [pbr::OriginalName("InvalidItemClass")] InvalidItemClass = 213,
    [pbr::OriginalName("CantFindCancelOrder")] CantFindCancelOrder = 214,
  }

  #endregion

}

#endregion Designer generated code