using SurpassApiSdk.DataContracts.TestForm;

namespace SurpassApiSdk.DataContracts.Section.Interfaces
{
    public interface ISectionExtendedResource
    {
        long? Id { get; set; }

        string Href { get; set; }

        string Name { get; set; }

        SectionType Type { get; set; }

        int? ItemsCount { get; set; }

        List<TestFormSectionItemBaseResource> SectionItems { get; set; }

        List<long> Projects { get; set; }
    }
}
