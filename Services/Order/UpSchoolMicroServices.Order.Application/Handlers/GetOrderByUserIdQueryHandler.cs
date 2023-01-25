using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UpSchoolECommerce.Shared.Dtos;
using UpSchoolMicroServices.Order.Application.DTOs;
using UpSchoolMicroServices.Order.Application.Queries;
using UpSchoolMicroServices.Order.Infrastructure;

namespace UpSchoolMicroServices.Order.Application.Handlers
{
    public class GetOrderByUserIdQueryHandler : IRequestHandler<GetOrdersByUserIdQuery, ResponseDto<List<OrderDto>>>
    {
        private readonly OrderDbContext _orderDbContext;
        private readonly IMapper _mapper;

        public GetOrderByUserIdQueryHandler(OrderDbContext orderDbContext,IMapper mapper)
        {
            _orderDbContext = orderDbContext;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<OrderDto>>> Handle(GetOrdersByUserIdQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderDbContext.Orders.Include(x => x.orderItems).Where(x => x.BuyerId == request.UserId).ToListAsync();
           
                return ResponseDto<List<OrderDto>>.Success(_mapper.Map<List<OrderDto>>(orders), 200);
           
        }
    }
}
