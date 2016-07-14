﻿using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IAppointmentsAdminApi
    {
        ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentRequest appointment);
        ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentRequest appointment);
        ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId);
        void DeleteAppointment(Guid appointmentId);
    }
}
