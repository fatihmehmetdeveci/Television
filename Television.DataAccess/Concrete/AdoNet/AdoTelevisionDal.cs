using Television.DataAccess.Abstract;
using Television.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Television.DataAccess.Concrete.ADONET
{
    public class AdoTelevisionDal : ITelevisionDal
    {
        public void Add(Entities.Concrete.Television entity)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Televisions (Name,Frequency,IsNewsChannel) " +
                "VALUES(@Name,@IsNewsChannel,@IsNewsChannel)"))
            {
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Frequency", entity.Frequency);
                cmd.Parameters.AddWithValue("@IsNewsChannel", entity.IsNewsChannel);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Entities.Concrete.Television entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Televisions WHERE TvID = @TvID"))
            {
                cmd.Parameters.AddWithValue("@TvID", entity.TvID);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public Entities.Concrete.Television Get(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            List<Entities.Concrete.Television> televisionList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Televisions");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television Television = new Entities.Concrete.Television
                {
                    TvID = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    Frequency = Convert.ToDouble(reader[1]),
                    IsNewsChannel = Convert.ToBoolean(reader[3])
                };

                televisionList.Add(Television);
            }
            var list = televisionList.Where(filter.Compile()).ToList();
            return list[0] ;
        }
        public List<Entities.Concrete.Television> GetFilter(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            List<Entities.Concrete.Television> televisionList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Televisions");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television television = new Entities.Concrete.Television
                {
                    TvID = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    Frequency = Convert.ToDouble(reader[2]),
                    IsNewsChannel = Convert.ToBoolean(reader[3].ToString())
                };

                televisionList.Add(television);
            }
            var list = televisionList.Where(filter.Compile()).ToList();
            return televisionList.Where(filter.Compile()).ToList(); ;
        }

        public List<Entities.Concrete.Television> GetAll(Expression<Func<Entities.Concrete.Television, bool>> filter = null)
        {

            List<Entities.Concrete.Television> televisionList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Televisions");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television television = new Entities.Concrete.Television
                {
                    TvID = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    Frequency = Convert.ToInt32(reader[2]),
                    IsNewsChannel = Convert.ToBoolean(reader[3].ToString())
                };

                televisionList.Add(television);
            }

            return filter == null ? televisionList : televisionList.Where(filter.Compile()).ToList();


        }

        public void Update(Entities.Concrete.Television entity)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Televisions set Name = @Name, IsNewsChannel=@IsNewsChannel, Frequency=@Frequency WHERE TvID = @TvID"))
            {
                cmd.Parameters.AddWithValue("@TvID", entity.TvID);
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@IsNewsChannel", entity.IsNewsChannel);
                cmd.Parameters.AddWithValue("@Frequency", entity.Frequency);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        
    }
}
