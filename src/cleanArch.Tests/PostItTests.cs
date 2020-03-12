using System;
using Xunit;
using cleanArch.Core;

namespace cleanArch.Tests
{
    public class PostItTests
    {
        [Fact]
        public void getTimeWordMinutes()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(0), "min");
        }

        [Fact]
        public void getTimeWordHour()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(60), "hour");
        }

        [Fact]
        public void getTimeWordDay()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(1440), "day");
        }

        [Fact]
        public void getTimeWordWeek()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(10080), "week");
        }

        [Fact]
        public void getTimeWordMonth()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(43800), "month");
        }

        [Fact]
        public void getTimeWordYear()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getTimeWord(525600), "year");
        }

        [Fact]
        public void convertMinutesToHours()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.convertMinutesInProperTimeValue(120, "hour"), 2);
        }

        [Fact]
        public void convertMinutesToDays()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.convertMinutesInProperTimeValue(1440 * 2, "day"), 2);
        }

        [Fact]
        public void convertMinutesToWeeks()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.convertMinutesInProperTimeValue(10080 * 2, "week"), 2);
        }

        [Fact]
        public void convertMinutesToMonths()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.convertMinutesInProperTimeValue(43800 * 2, "month"), 2);
        }

        

        [Fact]
        public void convertMinutesToYears()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.convertMinutesInProperTimeValue(525600 * 2, "year"), 2);
        }

        [Fact]
        public void getPostItAgeMinutes()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getPostItAge(new FakeClock(new DateTime(2020, 2,  10, 10, 55, 0))), "5 min");
        }

        [Fact]
        public void getPostItAgeDays()
        {
            PostIt post = new PostIt(new DateTime(2020, 2, 10, 10, 50, 0));

            Assert.Equal(post.getPostItAge(new FakeClock(new DateTime(2020, 2, 13, 10, 50, 0))), "3 day"); 
        }
    }

    class FakeClock : IClock
    {
        DateTime date {get;}
        public FakeClock(DateTime date) {
            this.date = date;
        }
        public DateTime Now() {
            return date;
        }
    }
}
