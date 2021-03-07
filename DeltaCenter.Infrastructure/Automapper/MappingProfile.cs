using AutoMapper;
using DeltaCenter.Core.Entities;
using DeltaCenter.Infrastructure.Dtos;
using System;
using System.Linq;

namespace DeltaCenter.Infrastructure.Automapper
{
	public class MappingProfile : Profile
	{
		public override string ProfileName => "MappingProfile";
		public MappingProfile()
		{
			//replaced with automapper attributes
			MapModelToDto();
			MapDtoToModel();
			MapModelToModel();
		}
		private void MapModelToDto()
		{
			CreateMap<Patient, PatientDto>()
				.IgnoreAllNonExisting();

			CreateMap<Diagnose, DiagnoseDto>()
				.IgnoreAllNonExisting();
			CreateMap<Medication, MedicationDto>()
				.IgnoreAllNonExisting();
			CreateMap<Visit, VisitDto>()
				.IgnoreAllNonExisting();
			CreateMap<VisitDiagnose, VisitDiagnoseDto>()
				.IgnoreAllNonExisting();
			CreateMap<VisitMedication, VisitMedicationDto>()
				.IgnoreAllNonExisting();
		}
		private void MapDtoToModel() {
			CreateMap<PatientDto, Patient>()
				.IgnoreAllNonExisting();
			CreateMap<DiagnoseDto, Diagnose>()
				.IgnoreAllNonExisting();
			CreateMap<VisitDto, Visit>()
				.IgnoreAllNonExisting();
			CreateMap<MedicationDto, Medication>()
				.IgnoreAllNonExisting();
			CreateMap<VisitMedicationDto, VisitMedication>()
				.IgnoreAllNonExisting();
			CreateMap<VisitDiagnoseDto, VisitDiagnose>()
				.IgnoreAllNonExisting();
		}

		private void MapModelToModel() {
			

		}
	}
}