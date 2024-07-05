using System.Collections;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace VueGrid.Models
{
    public interface IGridModel
    {
        IEnumerable rows { get; }
        int total { get; }
    }

    public class GridModel<T> : IGridModel
    {
        public GridModel()
        {
        }

        public GridModel(IEnumerable<T> rows)
        {
            this.rows = rows;
        }

        [JsonProperty("rows")]
        public IEnumerable<T> rows { get; set; }

        [IgnoreDataMember]
        IEnumerable IGridModel.rows
            => this.rows;

        [JsonProperty("total")]
        public int total { get; set; }

    }
}
