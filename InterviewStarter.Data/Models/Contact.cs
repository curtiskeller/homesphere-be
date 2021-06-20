using InterviewStarter.Data.Interfaces;

namespace InterviewStarter.Data.Models
{
    public class Contact : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}