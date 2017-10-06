using Xamarin.Forms;
using System;

namespace TodaysForune
{
    public partial class TodaysForunePage : ContentPage
    {
		public DateTime birthday;
        public string yourZodiac;
        public TodaysForunePage()
        {
            InitializeComponent();
            zodiacImg.Source = ImageSource.FromResource("TodaysForune.Aries.png");
        }

        void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            birthday = e.NewDate;
        }

        void Handle_Unfocused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            int month = birthday.Month;
            int day = birthday.Day;

            switch(month)
            {
                case 1:
                    if (day <= 19)
                    {
                        yourZodiac = "Capricorn";
                    } 
                    else
                    {
						yourZodiac = "Aquarius";
					}
					break;
				case 2:
					if (day <= 18)
					{
						yourZodiac = "Aquarius";
					}
					else
					{
						yourZodiac = "Pisces";
					}
					break;
				case 3:
					if (day <= 20)
					{
						yourZodiac = "Pisces";
					}
					else
					{
						yourZodiac = "Aries";
					}
					break;
				case 4:
					if (day <= 19)
					{
						yourZodiac = "Aries";
					}
					else
					{
						yourZodiac = "Taurus";
					}
					break;
				case 5:
					if (day <= 20)
					{
						yourZodiac = "Taurus";
					}
					else
					{
						yourZodiac = "Gemini";
					}
					break;
				case 6:
					if (day <= 20)
					{
						yourZodiac = "Gemini";
					}
					else
					{
						yourZodiac = "Cancer";
					}
					break;
				case 7:
					if (day <= 22)
					{
						yourZodiac = "Cancer";
					}
					else
					{
						yourZodiac = "Leo";
					}
					break;
				case 8:
					if (day <= 22)
					{
						yourZodiac = "Leo";
					}
					else
					{
						yourZodiac = "Virgo";
					}
					break;
				case 9:
					if (day <= 22)
					{
						yourZodiac = "Virgo";
					}
					else
					{
						yourZodiac = "Libra";
					}
					break;
				case 10:
					if (day <= 22)
					{
						yourZodiac = "Libra";
					}
					else
					{
						yourZodiac = "Scorpio";
					}
						break;
				case 11:
					if (day <= 21)
					{
						yourZodiac = "Scorpio";
					}
					else
					{
						yourZodiac = "Sagittarius";
					}
					break;
				case 12:
					if (day <= 19)
					{
						yourZodiac = "Sagittarius";
					}
					else
					{
						yourZodiac = "Capricorn";
					}
					break;

            }
            // title
            zodiacTitle.IsVisible = true;
            zodiacTitle.Text = yourZodiac;
            // image
            zodiacImg.IsVisible = true;
            zodiacImg.Source = ImageSource.FromResource("TodaysForune." + yourZodiac + ".png");
            //star
            starRank.IsVisible = true;

            // text
            zodiacDetail.IsVisible = true;
            switch(yourZodiac)
            {
                case "Capricorn":
                    starRank.Text = "★★☆☆☆";
                    zodiacDetail.Text = "With communicative Mercury linking to the Sun in your zone of ambition, you may find yourself in the spotlight, with others likely to take note of what you are saying. Bearing this in mind, the current backdrop encourages you to be upbeat and positive about yourself and others as your words may be remembered. Having a firm belief in your abilities might also enhance progress.";
                    break;
				case "Aquarius":
					starRank.Text = "★★★★☆";
					zodiacDetail.Text = "Yesterday's Full Moon may have brought information to light that could whet your appetite for more. You may want to travel to a place you have read about or learn more on a subject that you find personally rewarding, and this can be so good for you. On a deeper level, friends could seem resistant to changes you want to make unless you can explain why they are necessary.";
					break;
				case "Pisces":
                    starRank.Text = "★☆☆☆☆";
					zodiacDetail.Text = "Holding a heart-to-heart conversation could allow for positive changes to occur in a relationship that you may be deeply involved in. It could be a romantic bond, but equally it might be any other connection in which your affairs are entwined with another. It may be wise to do this soon and to clarify certain points, as a decision may be required that you'll need to be prepared for.";
					break;
				case "Aries":
					starRank.Text = "★★★★☆";
					zodiacDetail.Text = "Tempting though it can be, it is likely not possible to walk away from certain responsibilities even though you might want to. And if you do, you may end up taking on other obligations anyway, which can defeat the purpose. Bearing this in mind, it may be better to work with what you already have in place and perhaps make a few adjustments and tweaks where necessary.";
					break;
				case "Taurus":
					starRank.Text = "★★☆☆☆";
					zodiacDetail.Text = "With the weekend nearly here, a lovely line-up in your leisure zone can bring delightful invites and fun encounters. However, with sobering Saturn also in on the action, it could be tempting to ignore someone with who you may not see eye-to-eye. If you do, you might miss out on an opportunity to find out why. Could it be because you are more alike than you think Taurus?";
					break;
				case "Gemini":
					starRank.Text = "★★★★★";
					zodiacDetail.Text = "This can be a delightful day, and one that might see you organizing a family outing or enjoying recreational or cultural activities. You might look forward to spending time with friends too and enjoying a novel experience, such as going to a new restaurant or seeing a play or movie that inspires. Regarding a domestic issue though, it may be easier to compromise at this stage.";
					break;
				case "Cancer":
					starRank.Text = "★☆☆☆☆";
					zodiacDetail.Text = "As inquisitive Mercury ties to the Sun in your home zone, this can be a good time to discuss matters as a family and to make a few plans or reach a decision. However, if you are touching on edgier issues, then this conversation can herald a possible change. Concerning a work or personal project, try not to give yourself too much to do, as you could probably get away with less.";
					break;
				case "Leo":
					starRank.Text = "★★★☆☆";
					zodiacDetail.Text = "Are you denying yourself something that you really want Leo? The cosmic line-up hints that you may have the chance to enjoy a special treat, but for your own reasons you might decide not to. You may feel you don't deserve this, but you do without a doubt. If you have the time over coming days, let yourself enjoy a break and give up the idea that you need to keep working.";
					break;
				case "Virgo":
					starRank.Text = "★★☆☆☆";
					zodiacDetail.Text = "As the Moon links with the inspired qualities of Uranus in your sector of transformation, you could come away with insights that encourage you to break free of a situation or even a belief that is limiting you in some way. At the same time, you may be aware of a family situation that also needs to change. Don't fight it Virgo, as by embracing your feelings things can resolve.";
					break;
				case "Libra":
					starRank.Text = "★★★★☆";
					zodiacDetail.Text = "If it seems you are stuck concerning an issue and can't seem to move forward, then it may be that you are in two minds about this matter and they somehow cancel each other out. There is a way around this though, and it is to go with the flow. Don't force the pace, otherwise you could end up in further knots. However, if you are willing to let this unravel by itself, it eventually will.";
					break;
				case "Scorpio":
					starRank.Text = "★★☆☆☆";
					zodiacDetail.Text = "The ongoing focus on a private sector of your chart can be an opportunity to reacquaint yourself with your deeper nature. You may be no stranger to the cauldron of emotions that often bubbles away within, yet the present backdrop can allow you further insights into a complex situation. If you have tended to over-think this matter, then paying attention to your instincts might help you.";
					break;
				case "Sagittarius":
					starRank.Text = "★★★☆☆";
					zodiacDetail.Text = "Playful options may call out to you with unexpected invites and encounters adding sparkle to the day. At the same time, you could be in a position where you can make great strides forward with a personal goal or a career move, yet somehow feel unwilling to do the necessary work. This phase will pass later next week, but in the meantime, even the smallest step can benefit you.";
					break;


			}
        }
    }
}
