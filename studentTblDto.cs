using AutoMapper;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    [Serializable]
   public class studentTblDto
    {
        public int idStudent { get; set; }
        public string tzStudent { get; set; }
        public string lastName { get; set; }
        public string firstname { get; set; }
        public string connect { get; set; }
        public string kita { get; set; }
        public string madricha { get; set; }
        public string teacher { get; set; }
        public string @class { get; set; }
        public string miun { get; set; }
        public string phone { get; set; }
        public Nullable<int> yaad { get; set; }
        public Nullable<int> untill { get; set; }

        public studentTbl DtoToDal() {

            var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<studentTblDto, studentTbl>()
                 );
            var mapper = new Mapper(config);
            return mapper.Map<studentTbl>(this);

        }
        public static studentTblDto DalToDto(studentTbl student)
        {

            var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<studentTbl, studentTblDto>()
                 );
            var mapper = new Mapper(config);
            return mapper.Map<studentTblDto>(student);

        }
    }
}
