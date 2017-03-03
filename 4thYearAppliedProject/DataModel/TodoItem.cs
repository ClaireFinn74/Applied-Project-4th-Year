using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using AppliedProject4thYear.MainPages;
using _4thYearAppliedProject;

namespace _4thYearAppliedProject.DataModel
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "score")]
        //Serializing to Json to send the score over the internet 
        public string Score { get; set; }

        [JsonProperty(PropertyName = "complete")]
        //Serialising the 'ticked' functionality
        public bool Complete { get; set; }
    }
}
