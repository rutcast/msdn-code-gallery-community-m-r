﻿namespace MyCompany.Visitors.AzureEventBusPlugin.MessageHandlers
{
    using AutoMapper;
    using Microsoft.ServiceBus.Messaging;
    using MyCompany.Common.EventBus;
    using MyCompany.Visitors.Data;
    using MyCompany.Visitors.Data.Repositories;
    using MyCompany.Visitors.Model;
    using System;

    class ChangeEmployeePictureMessageHandler
        : MessageHandler
    {
        public override bool CanExecute(BrokeredMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            return message.ContentType == StaffActions.UpdateEmployeePicture;
        }

        public override void Handle(BrokeredMessage message)
        {
            var employeeRepository = new EmployeeRepository(new MyCompanyContext());
            var employeePictureRepository = new EmployeePictureRepository(new MyCompanyContext());

            var dto = message.GetBody<EmployeePictureDTO>();
            var employeePicture = Mapper.Map<EmployeePicture>(dto);

            var employee = employeeRepository.GetAsync(employeePicture.EmployeeId).Result;

            if (employee != null)
            {
                employeePictureRepository.UpdateAsync(employeePicture).Wait();
            }                
        }
    }
}
