﻿using Microsoft.EntityFrameworkCore;

namespace Chap_App.Models
{
    public class ChatAppContext: DbContext
    {
        public ChatAppContext(DbContextOptions<ChatAppContext>options): base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
