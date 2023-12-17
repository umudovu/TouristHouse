using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHouse.Application.Dtos.AnnounceDto;
using TouristHouse.Application.Dtos.HomeDto;

namespace TouristHouse.Application.Features.Commands.AnnounceCommands.HomeAnnounce
{
    public class CreateHomeAnnounceCommandRequest:IRequest<CreateHomeAnnounceCommandResponse>
    {
        public CreateHomeAnnounceDto CreateAnnounceDto { get; set; }
        //public CreateAnnounceDto? CreateAnnounceDto { get; set; }
        //public int FloorCount { get; set; }
        //public double Area { get; set; }
        //public int RoomCount { get; set; }
        //public int BedCount { get; set; }
    }
}
