using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using EmployeeManagementLibrary.Model;
using EmployeeManagementLibrary.Queries;
using System.Threading;

namespace EmployeeManagementLibrary.Handlers
{
    public class GetEmployeeByIdHandler: IRequestHandler<GetEmployeeByIdQuery, EmployeeModel>
    {
        private readonly IMediator _mediator;
        public GetEmployeeByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<EmployeeModel> Handle(GetEmployeeByIdQuery getEmployeeListQuery, CancellationToken cancellationToken)
        {
            var employees = await _mediator.Send(new GetEmployeeListQuery());
            var searchEmployees = employees.FirstOrDefault(x => x.ID == getEmployeeListQuery.ID);
            return searchEmployees;
        }
    }
}
