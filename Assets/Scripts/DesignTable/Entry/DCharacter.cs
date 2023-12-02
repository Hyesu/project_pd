using Newtonsoft.Json.Linq;
using HEngine.Extensions;
using DesignTable.Core;

namespace DesignTable.Entry
{
    public class DCharacter : DEntry
    {
        public readonly string Name;
        public readonly string ResourcePath;
        public readonly string Job;

        public DCharacter(JObject json)
            : base(json)
        {
            Name = json.GetString("Name");
            ResourcePath = json.GetString("ResourcePath");
            Job = json.GetString("Job");
        }
    }
}