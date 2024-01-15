using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace UserApp.Models
{
    public class UserPositionViewModel
    {
        public List<User>? Users { get; set; }
        public SelectList? Positions { get; set; }
        public string? UserPosition {  get; set; }
        public string? SearchString { get; set; }

    }
}
