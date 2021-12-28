using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using jkhkhkuhuh.Data;
using jkhkhkuhuh.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.ViewComponents
{
    public class VcNews : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcNews(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(string page)
        {
            VmVcNews model = new VmVcNews();
            //if (page == "Home")
            //{
            //    model.Blogs = await _context.Blogs.Include(u => u.User).OrderByDescending(o => o.CreatTime).Take(3).ToListAsync();
            //}
            //else
            //{
            //    model.Blogs = await _context.Blogs.Include(u => u.User).OrderByDescending(o => o.CreatTime).ToListAsync();
            //}
            model.Page = page;
            return View(model);
        }
    }
}