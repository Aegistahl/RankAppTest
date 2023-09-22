using System;
using Microsoft.EntityFrameworkCore;

namespace RankingAppTest.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}


		public DbSet<ItemModel> ItemModels => Set<ItemModel>();

	}
}

