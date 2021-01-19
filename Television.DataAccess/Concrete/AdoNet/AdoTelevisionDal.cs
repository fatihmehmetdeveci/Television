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
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Hotels (HotelName,FeePerNight,Stars) " +
                "VALUES(@HotelName,@FeePerNight,@Stars)"))
            {
                cmd.Parameters.AddWithValue("HotelName", entity.HotelName);
                cmd.Parameters.AddWithValue("FeePerNight", entity.FeePerNight);
                cmd.Parameters.AddWithValue("Stars", entity.Stars);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Entities.Concrete.Television entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Hotels WHERE HotelId = @HotelId"))
            {
                cmd.Parameters.AddWithValue("HotelId", entity.HotelId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public Entities.Concrete.Television Get(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            List<Entities.Concrete.Television> hotelList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Hotels");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television hotel = new Entities.Concrete.Television
                {
                    HotelId = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    Stars = Convert.ToInt32(reader[2]),
                    FeePerNight = Convert.ToDecimal(reader[3].ToString())
                };

                hotelList.Add(hotel);
            }
            var list = hotelList.Where(filter.Compile()).ToList();
            return list[0] ;
        }
        public List<Entities.Concrete.Television> GetFilter(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            List<Entities.Concrete.Television> hotelList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Hotels");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television hotel = new Entities.Concrete.Television
                {
                    HotelId = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    Stars = Convert.ToInt32(reader[2]),
                    FeePerNight = Convert.ToDecimal(reader[3].ToString())
                };

                hotelList.Add(hotel);
            }
            var list = hotelList.Where(filter.Compile()).ToList();
            return hotelList.Where(filter.Compile()).ToList(); ;
        }

        public List<Entities.Concrete.Television> GetAll(Expression<Func<Entities.Concrete.Television, bool>> filter = null)
        {

            List<Entities.Concrete.Television> hotelList = new List<Entities.Concrete.Television>();
            SqlCommand cmd = new SqlCommand("Select * from Hotels");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Entities.Concrete.Television hotel = new Entities.Concrete.Television
                {
                    HotelId = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    Stars = Convert.ToInt32(reader[2]),
                    FeePerNight = Convert.ToDecimal(reader[3].ToString())
                };

                hotelList.Add(hotel);
            }

            return filter == null ? hotelList : hotelList.Where(filter.Compile()).ToList();


        }

        public void Update(Entities.Concrete.Television entity)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Hotels set HotelName = @HotelName, FeePerNight=@FeePerNight, Stars=@Stars WHERE HotelId = @HotelId"))
            {
                cmd.Parameters.AddWithValue("@HotelId", entity.HotelId);
                cmd.Parameters.AddWithValue("@HotelName", entity.HotelName);
                cmd.Parameters.AddWithValue("@FeePerNight", entity.FeePerNight);
                cmd.Parameters.AddWithValue("@Stars", entity.Stars);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        
    }
}
