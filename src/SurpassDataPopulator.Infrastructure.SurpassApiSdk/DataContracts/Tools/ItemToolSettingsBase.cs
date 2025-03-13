using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Tools.Calculator;
using SurpassApiSdk.DataContracts.Tools.Caliper;

namespace SurpassApiSdk.DataContracts.Tools;

[KnownType(typeof(CalculatorToolSettings))]
[KnownType(typeof(CaliperToolSettings))]
[DataContract(Namespace = "")]
public class ItemToolSettingsBase
{
}