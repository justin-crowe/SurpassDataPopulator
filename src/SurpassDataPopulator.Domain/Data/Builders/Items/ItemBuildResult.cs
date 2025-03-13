using System.Collections.Generic;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.Items;

public class ItemBuildResult
{
    public List<Item> Items { get; set; }
}