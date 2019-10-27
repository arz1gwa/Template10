﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Template10.SampleData.StarTrek;

namespace Sample.Models
{
    public class GroupedMembers
    {
        public Show Show { get; set; }
        public ObservableCollection<Member> Members { get; set; }
    }
}
