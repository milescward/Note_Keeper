using System;
using System.Collections.Generic;
using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get
            {
                return Note.Heading;
            }
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }

        

        public ItemDetailViewModel(Note note = null)
        {
            Title = "Edit note";
            InitializeCourseList();
            Note = note ?? new Note();
        }

        public async void InitializeCourseList()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }

    }
}
