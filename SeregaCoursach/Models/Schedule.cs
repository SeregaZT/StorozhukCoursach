using StorozhukCoursach.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorozhukCoursach.Models {
    class Schedule {
        public int ScheduleId { get; set; }
        public Days Day { get; set; }
        public Partition Partition { get; set; }
        public LessonTypes LessonType { get; set; }
        public int GroupId { get; set; }
        public int PairNum { get; set; }
        public int RoomId { get; set; }
        public int SubjectId { get; set; }
    }
}
