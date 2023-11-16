using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.GB_Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class DormantRegisterService : IDormantRegister
    {
        private readonly General_Banking_RegistersContext _generalBankingRegistersContext;

        public DormantRegisterService(General_Banking_RegistersContext generalBankingRegistersContext)
        {
            _generalBankingRegistersContext = generalBankingRegistersContext;
        }

        public VmDormantRegister AddDormantRegister(VmDormantRegister dormantRegister)
        {
            var dormantRegister1 = new DormantRegister()
            {

                DateRequested = DateTime.Now,
                AcctNumber = dormantRegister.AcctNumber,
                Name = dormantRegister.Name,
                PreviousBalance = 11,
                Particulars = dormantRegister.Particulars,
                InitialIdEmployee = 33,
                ReactivateIdEmployee = 269,
                DatePerformed = DateTime.Now,
                EntryStatusId = 2,
                //AcctTypeId = 1,
                CoreBranchNumber = "00",
                IssuingDeptId = dormantRegister.IssuingDeptId,
                AcctStatus = "D",
                AcctType = "SAV"

            };

            try
            {
                _generalBankingRegistersContext.DormantRegisters.Add(dormantRegister1);
                _generalBankingRegistersContext.SaveChanges();

                var result = new VmDormantRegister()
                {
                    DateRequested = dormantRegister.DateRequested,
                    AcctNumber = dormantRegister.AcctNumber,
                    Name = dormantRegister.Name,
                    PreviousBalance = dormantRegister.PreviousBalance,
                    Particulars = dormantRegister.Particulars,
                    InitialIdEmployee = dormantRegister.InitialIdEmployee,
                    ReactivateIdEmployee = dormantRegister.ReactivateIdEmployee,
                    DatePerformed = dormantRegister.DatePerformed,
                    EntryStatusId = dormantRegister.EntryStatusId,
                    CoreBranchNumber = dormantRegister.CoreBranchNumber,
                    IssuingDeptId = dormantRegister.IssuingDeptId,
                    AcctStatus = dormantRegister.AcctStatus,
                    AcctType = dormantRegister.AcctType

                };
                return result;
            }

            catch (Exception ex)
            {
                return null;
            }

        }


        public VmDormantRegister GetDormantRegister(VmDormantRegister dormantRegister, string acctNumber)
        {
            VmDormantRegister vmDormantRegister;
            try
            {
                var result = _generalBankingRegistersContext.DormantRegisters.Where(x => x.AcctNumber == acctNumber).FirstOrDefault();

                vmDormantRegister = new VmDormantRegister()
                {
                    DateRequested = result.DateRequested,
                    RecordId = result.RecordId,
                    AcctNumber = result.AcctNumber,
                    Name = result.Name,
                    PreviousBalance = result.PreviousBalance,
                    InitialIdEmployee = result.InitialIdEmployee,
                    ReactivateIdEmployee = result.ReactivateIdEmployee,
                    DatePerformed = result.DatePerformed,
                    EntryStatusId = result.EntryStatusId,
                    CoreBranchNumber = result.CoreBranchNumber,
                    IssuingDeptId = result.IssuingDeptId,
                    AcctStatus = result.AcctStatus,
                    AcctType = result.AcctType,

                };
                return vmDormantRegister;
            }
            catch (Exception ex)
            {
                return new VmDormantRegister();
            }
        }

        public VmDormantRegister UpdateDormant(string? acctNumber, int recordId)
        {
            try
            {
                var result = _generalBankingRegistersContext.DormantRegisters.SingleOrDefault(x => x.RecordId == recordId);

                if (result != null)
                {
                    var dormant = new VmDormantRegister()
                    {
                        RecordId = result.RecordId,
                        AcctNumber = result.AcctNumber,
                        DatePerformed = result.DatePerformed,
                        EntryStatusId = result.EntryStatusId,
                        ReactivateIdEmployee = result.ReactivateIdEmployee,
                        Name = result.Name,
                        Particulars = result.Particulars
                    };

                    return dormant;
                }
            }
            catch (Exception ex)
            {
                return new VmDormantRegister();
            }

            return new VmDormantRegister();
        }

        public VmDormantRegister UpdateDormant(VmDormantRegister dormantRegister)
        {
            var dormantRegister1 = new DormantRegister()
            {
                RecordId = dormantRegister.RecordId,
                DateRequested = DateTime.Now,
                AcctNumber = dormantRegister.AcctNumber,
                Name = dormantRegister.Name,
                PreviousBalance = 11,
                Particulars = dormantRegister.Particulars,
                InitialIdEmployee = 33,
                ReactivateIdEmployee = 269,
                DatePerformed = DateTime.Now,
                EntryStatusId = 2,
                //AcctTypeId = 1,
                CoreBranchNumber = "00",
                IssuingDeptId = dormantRegister.IssuingDeptId,
                AcctStatus = "D",
                AcctType = "SAV",
            };

            try
            {
                _generalBankingRegistersContext.DormantRegisters.Update(dormantRegister1);
                _generalBankingRegistersContext.SaveChanges();

                var result = new VmDormantRegister()
                {
                    DateRequested = DateTime.Now,
                    AcctNumber = dormantRegister1.AcctNumber,
                    Name = dormantRegister1.Name,
                    PreviousBalance = 11,
                    Particulars = dormantRegister1.Particulars,
                    InitialIdEmployee = 33,
                    ReactivateIdEmployee = 269,
                    DatePerformed = DateTime.Now,
                    EntryStatusId = 2,
                    //AcctTypeId = 1,
                    CoreBranchNumber = "00",
                    IssuingDeptId = dormantRegister1.IssuingDeptId,
                    AcctStatus = "D",
                    AcctType = "SAV",
                    RecordId = dormantRegister1.RecordId

                };
                return result;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public List<VmDormantRegister> ViewDormant(string search, int? EntryStatusId, DateTime date, int pg = 1)
        {
            List<VmDormantRegister> dormantList = new List<VmDormantRegister>();
            try
            {
                var dormants = _generalBankingRegistersContext.DormantRegisters.Where(w => w.EntryStatusId == EntryStatusId || w.AcctNumber == search).ToList();

                if (dormants != null)
                {
                    if (String.IsNullOrEmpty(search))
                    {
                        foreach (var dormant in dormants)
                        {
                            var vmDormantRegister = new VmDormantRegister()
                            {
                                RecordId = dormant.RecordId,
                                DateRequested = dormant.DateRequested,
                                AcctNumber = dormant.AcctNumber,
                                Name = dormant.Name,
                                PreviousBalance = dormant.PreviousBalance,
                                Particulars = dormant.Particulars,
                                InitialIdEmployee = dormant.InitialIdEmployee,
                                ReactivateIdEmployee = dormant.ReactivateIdEmployee,
                                DatePerformed = dormant.DatePerformed,
                                EntryStatusId = dormant.EntryStatusId,
                                AcctTypeId = dormant.AcctTypeId,
                                CoreBranchNumber = dormant.CoreBranchNumber,
                                IssuingDeptId = dormant.IssuingDeptId,
                                AcctStatus = dormant.AcctStatus,
                                AcctType = dormant.AcctType

                            };
                            dormantList.Add(vmDormantRegister);
                        }
                    }
                    else
                    {
                        dormants = dormants.Where(w => w.EntryStatusId == EntryStatusId || w.AcctNumber.ToLower().Contains(search.ToLower())).ToList();

                        foreach (var dormant in dormants)
                        {
                            var vmDormantRegister = new VmDormantRegister()
                            {
                                RecordId = dormant.RecordId,
                                DateRequested = dormant.DateRequested,
                                AcctNumber = dormant.AcctNumber,
                                Name = dormant.Name,
                                PreviousBalance = dormant.PreviousBalance,
                                Particulars = dormant.Particulars,
                                InitialIdEmployee = dormant.InitialIdEmployee,
                                ReactivateIdEmployee = dormant.ReactivateIdEmployee,
                                DatePerformed = dormant.DatePerformed,
                                EntryStatusId = dormant.EntryStatusId,
                                AcctTypeId = dormant.AcctTypeId,
                                CoreBranchNumber = dormant.CoreBranchNumber,
                                IssuingDeptId = dormant.IssuingDeptId,
                                AcctStatus = dormant.AcctStatus,
                                AcctType = dormant.AcctType
                            };
                            dormantList.Add(vmDormantRegister);
                        }
                    }

                }

                //return dormantList;
            }

            catch (Exception ex)
            {

            }

            return dormantList;

        }

        public List<EntityStatusVM> GetEntityStatus()
        {
            List<EntityStatusVM> dormantList = new List<EntityStatusVM>();

            try
            {
                dormantList = _generalBankingRegistersContext.EntryStatuses.Select(s => new EntityStatusVM()
                {
                    Id = s.EntryStatusId,
                    Name = s.EntryStatusDescription
                }).ToList();

                return dormantList;
            }

            catch (Exception ex)
            {
                return new List<EntityStatusVM>();
            }
        }

        public VmDormantRegister DeleteDormant(int recordId)
        {
            try
            {
                var result = _generalBankingRegistersContext.DormantRegisters.SingleOrDefault(x => x.RecordId == recordId);
                _generalBankingRegistersContext.DormantRegisters.Remove(result);
                _generalBankingRegistersContext.SaveChanges();

                if (result != null)
                {
                    var dormant = new VmDormantRegister()
                    {
                        RecordId = result.RecordId,
                        AcctNumber = result.AcctNumber,
                        DatePerformed = result.DatePerformed,
                        EntryStatusId = result.EntryStatusId,
                        ReactivateIdEmployee = result.ReactivateIdEmployee,
                        Name = result.Name,
                        Particulars = result.Particulars
                    };

                    return dormant;
                }
            }
            catch (Exception ex)
            {
                return new VmDormantRegister();
            }

            return new VmDormantRegister();
        }

    }
}
