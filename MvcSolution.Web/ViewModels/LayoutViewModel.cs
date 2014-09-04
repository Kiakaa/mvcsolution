﻿using System.Web;
using MvcSolution.Services.Users;

namespace MvcSolution.Web.ViewModels
{
    public class LayoutViewModel
    {
        public string Title { get; set; }
        public string Error { get; set; }

        public SessionUser User
        {
            get { return HttpContext.Current.Session.GetMvcSolutionSession().User; }
        }
    }

    public class LayoutViewModel<T> : LayoutViewModel
    {
        public T Model { get; set; }
    }
}