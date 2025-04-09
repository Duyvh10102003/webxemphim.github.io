﻿using Microsoft.AspNetCore.Identity;

namespace WebsiteXemPhim.Models
{
    public class DanhGia
    {
        public int DanhGiaId { get; set; }
        public int? PhimBoId { get; set; }
        public int? PhimLeId { get; set; }
        public string UserId { get; set; }
        public PhimBo? PhimBo { get; set; }
        public PhimLe? PhimLe { get; set; }
        public AppUser User { get; set; }
        public float Star {  get; set; }
    }
    public class DanhGiaModel
    {
        public int? PhimBoId { get; set; }
        public int? PhimLeId { get; set; }
        public float Star { get; set; }
    }
}
