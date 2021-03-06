﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }

        public EmployeeVM RequestingEmployee { get; set; }
        [Display(Name = "Employee Name")]
            public string RequestingEmployeeId { get; set; }
        [Display(Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
            public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        [DataType(DataType.Date)]
            public DateTime EndDate { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime CancelledDate { get; set; }
        public string Comments { get; set; }
    }

    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }
        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }

    public class CreateLeaveRequestVM
    {
        [Display(Name = "start Date")]
        [Required]
            public string StartDate { get; set; }
        [Display(Name = "start Date")]
        [Required]
            public string EndDate { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        [Display(Name = "Leave Type")]
            public int LeaveTypeId { get; set; }
        public string Comments { get; set; }
    }
    public class ViewRequestsAndAllocationsVM
    {
        public List<LeaveRequestVM> LeaveRequests { get; set; }
        public string EmployeeId { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
