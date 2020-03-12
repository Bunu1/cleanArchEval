using System;

namespace cleanArch.Core
{
    public class PostIt
    {
        public DateTime createdAt { get; private set; }
        public string title { get; private set; }
        public string content { get; private set; }
        
        public PostIt(DateTime createdAt, string title = "", string content = "") {
            this.createdAt = createdAt;
            this.title = title;
            this.content = content;
        }

        public string getTimeWord(int numberOfMinutes) {
            if(numberOfMinutes >= 525600) {
                return "year";
            } else if (numberOfMinutes >= 43800 && numberOfMinutes < 525600) {
                return "month";
            } else if (numberOfMinutes >= 10080 && numberOfMinutes < 43800) {
                return "week";
            } else if (numberOfMinutes >= 1440 && numberOfMinutes < 10080) {
                return "day";
            } else if (numberOfMinutes >= 60 && numberOfMinutes < 1440) {
                return "hour";
            }

            return "min";
        }

        public int convertMinutesInProperTimeValue(int minutes, string word) {
            switch(word) {
                case "year":
                    return minutes / 525600;
                case "month":
                    return minutes / 43800;
                case "week":
                    return minutes / 10080;
                case "day":
                    return minutes / 1440;
                case "hour":
                    return minutes / 60;
            }

            return minutes;
        }
        public string getPostItAge(IClock clock) {
            var minutes = (clock.Now() - this.createdAt).Minutes;
            var word = getTimeWord(minutes);
            var timeValue = convertMinutesInProperTimeValue(minutes, word);

            return $"{timeValue} {word}";
        }

        public void displayPostItInformations() {
            Console.WriteLine(getPostItAge(new DefaultClock()));
        }
    }
}
