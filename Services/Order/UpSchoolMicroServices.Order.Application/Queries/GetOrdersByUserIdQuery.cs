using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolECommerce.Shared.Dtos;
using UpSchoolMicroServices.Order.Application.DTOs;

namespace UpSchoolMicroServices.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery:IRequest<ResponseDto<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
