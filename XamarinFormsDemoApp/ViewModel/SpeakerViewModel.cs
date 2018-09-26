using System;
using System.Collections.Generic;
using XamarinFormsDemoApp.Model;

namespace XamarinFormsDemoApp.ViewModel
{
    public class SpeakerViewModel
    {
        public List<Speaker> Speakers { get; set; }

        public SpeakerViewModel()
        {
            Speakers = new Speaker().GetSpeakers();
        }
    }
}
