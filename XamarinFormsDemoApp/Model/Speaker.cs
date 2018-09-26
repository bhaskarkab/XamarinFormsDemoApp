using System;
using System.Collections.Generic;

namespace XamarinFormsDemoApp.Model
{
    public class Speaker
    {
        public string SpeakerName { get; set; }
        public string Topic { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public List<Speaker> GetSpeakers() {

            List<Speaker> speakers = new List<Speaker>()
            {
                new Speaker(){
                    SpeakerName="Mads Torgersen",
                    Topic="International Speaker",
                    ShortDescription="Principal Program Manager at Microsoft, Lead Designer of C#, International Speaker ",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2017/12/madst.png",
                    Description="Mads Torgersen is a Principal Program Manager at Microsoft, and the lead designer of C#. He also contributes to Visual Basic, and helped design the first version of TypeScript. Before joining Microsoft in 2005 he was a researcher, and contributed to Java generics."
                },
                new Speaker(){
                    SpeakerName="Mahesh Chand",
                    Topic="International Speaker",
                    ShortDescription="Founder C# Corner, CEO Mindcracker, Microsoft Regional Director, Startup Adviser",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2018/01/Mahesh.png",
                    Description="Mahesh Chand is a founder of C# Corner, Microsoft Regional Director, 12-times Microsoft MVP, Technical Author, International Speaker, and Startup Adviser. Mahesh has written half a dozen books with publishers including Addison-Wesley and Apress. His role as the CEO of Mindcracker Inc, he helps businesses build their next generation digital platforms and help with their product strategy including architecture, migration, and innovation."
                },
                new Speaker(){
                    SpeakerName="Magnus Martensson",
                    Topic="International Speaker",
                    ShortDescription="Microsoft Regional Director, Azure MVP, CEO Loftysoft",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2016/12/MagnusNew.png",
                    Description="Magnus specializes in Cloud Computing technologies in general and the Microsoft Azure Cloud Platform in particular.Magnus is the first Microsoft Azure Most Valuable Professional in the Nordic Countries, a Microsoft Azure Insider and a Microsoft Azure Advisor and have also been awarded MVP of the Year in 2012."
                },
                new Speaker(){
                    SpeakerName="Jason Beres",
                    Topic="International Speaker",
                    ShortDescription="Sr.VP Developer Tools at Infragistics, Author, International Speaker",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2018/01/JsonB.png",
                    Description="Jason is a software executive with over 20 years of experience in Microsoft related technologies.With an extensive experience in managing teams of various disciplines in the software development lifecycle, Jason has been managing and shipping multiple products per year on time and within budget."
                        +"\n\n"+"He is passionate about technical education, delivering dozens of technical user group, conference, and webinar talks consistently for the last decade.Not only this, he is passionate about high - tech and bleeding edge software and hardware that deliver an exceptional user experience.His rich skill - set includes - Leadership, product management, global product strategy, public speaking, user experience design, business development, partnerships, & coaching."
                },
                new Speaker(){
                    SpeakerName="Diksha Deo",
                    Topic="International Speaker",
                    ShortDescription="Founder and CEO Incubsence, Co-Founder CKHO, Speaker, Writer",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2017/12/Diksha.png",
                    Description="Diksha is the Field Marshal of INCUBSENCE, thriving to Innovate, Manufacture & Launch scalable products.As innovation strategist & Massachusetts Institute of Technology Bootcamper, she brings 7 + years of expertise in connected devices, cloud platforms & enterprise technologies.She impacted 75 + CXOís & more than 23k people through 250 + tech talks."
                        +"\n\n"+"Since 3 + years she is a prominent voice of Women Who Code & heads IoT division and also contributed to the growth of three girls from Indian Institute of Information Technology, Delhi at Rails Girls Summer of Code(RGSoC) in 2017, a codejam by Tessel. She is also associated with Google Women TechMakers since 17 months."
                        +"\n\n"+"Her philanthrophic organization CKHO is a platform augmenting computer awareness among the underprivileged by utilizing a vast network of co - working spaces existing in the metropolitan cities."
                },
                new Speaker(){
                    SpeakerName="Chris Trew",
                    Topic="International Speaker",
                    ShortDescription="Founder & CEO Stratis",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2018/02/chris_t.png",
                    Description="Chris is a consultant, architect and technologist with over 10 yearsí experience in Enterprise IT. Chrisís background includes extensive experience in the financial sector, working for some of the top financial institutions as well as in the Legal, Aviation and Local government sectors."
                        +"\n\n"+"Chris is also a backend developer specializing in C# and ASP.NET technologies. He has been involved in blockchain technologies since late 2013, Most recently Chris has worked as a volunteer developer in his free time on the Blitz project, in the course of which he has developed The Viral Exchange, a social exchange that allows people to earn BTC and Blitz by completing social interactions such as tweets, sharing and likes. He also created the Fitalize platform that allows people to earn Blitz by walking, using hardware fitness trackers such as Fitbit."
                },
                new Speaker(){
                    SpeakerName="Pinal Dave",
                    Topic="International Speaker",
                    ShortDescription="Founder - SQL Authority, Independent Consultant, International Speaker",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2018/02/PinalDave.png",
                    Description="Pinal Dave is a Independent Consultant.He has authored 10 Pluralsight Courses and 10 SQL Server database books and have written over 2600 articles on the database technology on his blog at a www.blog.sqlauthority.com.Along with 10 + years of hands on experience he holds a Masters of Science degree and a number of certifications, including MCTS, MCDBA and MCAD(.NET).His past work experiences include Technology Evangelist at Microsoft and Sr.Consultant at SolidQ."
                },
                new Speaker(){
                    SpeakerName="Jeff Prosise",
                    Topic="International Speaker",
                    ShortDescription="Co - Founder Wintellect, Author, International Speaker",
                    ImageUrl="http://conference.c-sharpcorner.com/wp-content/uploads/2017/12/Jeff.png",
                    Description="Jeff is a Co - Founder of Wintellect who makes his living writing software and helping others do the same.He has written nine books and hundreds of magazine articles, trained thousands of developers at Microsoft, and spoken at some of the worldís largest software conferences.In his former life as a mechanical and aerospace engineer, Jeff worked at Oak Ridge National Lab and Lawrence Livermore National Lab, where, among other things, he developed software that combined thermal and structural finite - element methods to model optical systems for high - power laser beams.In his spare time, Jeff builds and flies large radio - control jets, and travels to development shops, universities, and research institutions around the world educating them about Microsoft Azure and the intersection of software development and data science."
                },
                new Speaker()
                {
                    SpeakerName = "Joseph Guadagno",
                    Topic = "International Speaker",
                    ShortDescription = "International Speaker, Microsoft MVP, Lead Quicken Loans",
                    ImageUrl = "http://conference.c-sharpcorner.com/wp-content/uploads/2017/01/Joseph-1.png",
                    Description = "With an experience of over 20 years, Joseph is working as Team Leader at Quicken Loans, Detroit.He has seen the IT industry taking shape from DOS to Windows 10.He is master of many development tools and languages, and has worked on several technologies, from a small book on QuickBASIC, to Visual Basic for DOS, to Visual Basic for Windows, to Visual C#. Currently, he is a public speaker, organizer of Desert Code Camp, published author, former President and VP of INETA (North America). He presents internationally on a lot of different technology topics and his contribution to the developer community has lead him to achieve recognition as Friend of Red Gate program (since 2015) and 5 times Microsoft MVP."
                },
                new Speaker()
                {
                    SpeakerName = "Bill Wolff",
                    Topic = "International Speaker",
                    ShortDescription = "CEO Agility Systems, Founder / President PhillyCodeCamp, INETA, VP Speaker Bureau",
                    ImageUrl = "http://conference.c-sharpcorner.com/wp-content/uploads/2018/03/Bill_Wolff.png",
                    Description = "Bill is an independent consultant, trainer, and architect specializing in Microsoft development technologies under the name Agility Systems.He served as the SharePoint Practice Director at Capax Global, Solutions Architect in the Microsoft Practice at Unisys Corporation, and ran the Microsoft Alliance at LiquidHub.He ran the consulting firm Wolff Data Systems for 15 years and directed armies of consultants in the dot com world.Bill is founder and President of the philly.NET user group, a previous INETA board member where he served as Vice President of the Speaker Bureau, and involved in several other user communities.Bill was a contributing author on several books.His certifications include trainer, systems engineer, developer, and Microsoft MVP for 14 years."
                }
            };

            return speakers;
        }
    }
}
