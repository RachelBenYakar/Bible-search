namespace DTO
{
        public class Pasook
        {
            public string Number { get; set; }
            public string Text { get; set; }
        }

        public class Chapter
        {
            public string Title { get; set; }
            public List<Pasook> Psookim { get; set; } = new List<Pasook>();
        }

        public class Parashah
        {
            public string Title { get; set; }
            public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        }
        public class Place
        {
            public string Parashah { get; set; }
            public string Perek { get; set; }
            public Pasook Pasook { get; set; }
        }

    }
