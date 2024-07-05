using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace VueGrid.Models
{
    public class SortDescriptor
    {
        [JsonProperty("member")]
        public string Member { get; set; }

        [JsonProperty("descending")]
        public bool Descending { get; set; }
    }

    public class GridCommand
    {
        [IgnoreDataMember]
        public string GridId { get; set; }

        [IgnoreDataMember]
        public bool InitialRequest { get; set; }

        /// <summary>
        /// Required for state preservation.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        [JsonProperty("pageSize")]
        public int PageSize { get; set; } = 25;

        [JsonProperty("sorting")]
        public List<SortDescriptor> Sorting { get; } = new();

        [JsonProperty("filters")]
        public List<object> Filters { get; } = new();

        [JsonProperty("groups")]
        public List<object> Groups { get; } = new();

        [JsonProperty("aggregates")]
        public List<object> Aggregates { get; } = new();
    }
}
