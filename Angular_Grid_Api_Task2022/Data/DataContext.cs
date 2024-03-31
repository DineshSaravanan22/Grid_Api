using Microsoft.EntityFrameworkCore;
using Angular_Grid_Api_Task2022.Entities;


namespace Angular_Grid_Api_Task2022.Data
{
    public class DataContext : DbContext  
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){
        
        }
        public DbSet<AgGrid> AgGrids { get; set; }
    }
}
