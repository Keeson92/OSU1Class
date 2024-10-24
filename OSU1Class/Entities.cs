using System.Reflection.Metadata;

namespace OSU1Class
{
    public class Entities
    {
        public class Lokal
        {
            public string Type { get; set; }
            public int Seats { get; set; }
            public string RoomID {  get; set; } 
        }
        public class Teacher
        {
            public string Email { get; set; }
            public int PhoneNo { get; set; }

            public string Signature { get; set; }
        }

        public class Systemadministrator
        { 
            public string Email { get; set; }

            private int Access {  get; set; }

            public int PhoneNo {  get; set; }

            public string Signature { get; set; }
            
        }
        
        public class Program
        {
            public string Acronyme { get; set; }
            public string Name { get; set; }
            public int StartDate { get; set; }
        }

        public class Coursemoment
        {
            public int StartDate { get; set; }

            public int EndDate { get; set; }

            public string CourseManager { get; set; }

            private string CourseMembers { get; set; }

            public string Acronyme { get; set; }


        }

        public class ScheduleTime
        {
            public int Week { get; set; }

            public int Day { get; set; }

            public int Month { get; set; }

            public string Acronyme { get; set; }

            public string Group { get; set; }

            public string Signature { get; set; }

            public string Room { get; set; }

            public string HelpMoment { get; set; }

            public string Moment { get; set; }
        
        }

        public class Schedule
        { 
            public int CourseID { get; set; }
        }

        public class User
        {
            public string FirstName { get; set;}

            public string LastName { get; set; }

            private int SocSecNo { get; set; }
        }
            }
}
