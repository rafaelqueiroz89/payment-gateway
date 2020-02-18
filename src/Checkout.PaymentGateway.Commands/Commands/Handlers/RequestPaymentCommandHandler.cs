﻿using System.Threading;
using System.Threading.Tasks;

using Checkout.PaymentGateway.Domain.Exceptions;
using Checkout.PaymentGateway.Domain.PaymentAggregate;

using MediatR;

namespace Checkout.PaymentGateway.CQRS.Commands.Handlers
{
    /// <summary>
    /// Handler for requesting a payment, it is internal to the API microservice
    /// </summary>
    /// <seealso cref="MediatR.IRequestHandler{Checkout.PaymentGateway.CQRS.Commands.RequestPaymentCommand, Checkout.PaymentGateway.Domain.PaymentAggregate.ResponsePaymentAggregate}" />
    internal class RequestPaymentCommandHandler : IRequestHandler<RequestPaymentCommand, ResponsePaymentAggregate>
    {
        /// <summary>
        /// Handles the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<ResponsePaymentAggregate> Handle(RequestPaymentCommand request, CancellationToken cancellationToken)
        {
            throw new PaymentRefusedException("Payment refused");
        }
    }
}