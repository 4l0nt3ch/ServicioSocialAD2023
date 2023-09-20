using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies;
using uanl_ss_lib_entities_api.GlobalEntities.Dependencies.Types;
using uanl_ss_lib_entities_api.GlobalEntities.Roles;
using uanl_ss_lib_entities_api.GlobalEntities.Roles.Types;
using uanl_ss_lib_entities_api.GlobalEntities.Misc;
using SH = uanl_ss_lib_office_excel_local_api.Helpers.StringHelpers;

namespace uanl_ss_lib_office_excel_local_api.MinimalAdapterClass
{
    public static class CSExcelRowToGlobalClass
    {
        public static List<CSPrograma> ProgramaExcelToObj(List<CSMinExcelRowRecord> rowRecord,
            CSDepEducativa depEducativa, CSCoordinador coordinador, CSPeriodo periodo) {

            List<CSPrograma> programas = new List<CSPrograma>();
            
            foreach (CSMinExcelRowRecord row in rowRecord) {

                programas.Add(
                    new CSPrograma(
                        SH.SHValidateExcelString(string.Empty),
                        EmpresaExcelToObj(row),
                        DependenciaExcelToObj(row, depEducativa),
                        DepartamentoExcelToObj(row),
                        SH.SHValidateExcelString(row.programa.Descripcion),
                        ComunidadExcelToObj(row),
                        ResponsableExcelToObj(row),
                        CoordinadorExcelToObj(coordinador),
                        AlumnoExcelToObj(row),
                        TurnoExcelToObj(row),
                        ActividadExcelToObj(row),
                        PeriodoExcelToObj(periodo))
                    );

            }

            return programas;
        }

        public static CSEmpresa EmpresaExcelToObj(CSMinExcelRowRecord record) {

            return new CSEmpresa(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.empresa.RazonSocial),
                new CSTipoEmpresa(
                    SH.SHValidateExcelString(string.Empty),
                    SH.SHValidateExcelString(record.empresa.Tipo)
                ),
                SH.SHValidateExcelString(record.empresa.RFC),
                SH.SHValidateExcelString("AV. PEDRO DE ALBA S/N, CIUDAD UNIVERSITARIA, C.P. 64451"),
                SH.SHValidateExcelString(record.empresa.Pais),
                SH.SHValidateExcelString(record.empresa.Estado),
                SH.SHValidateExcelString(record.empresa.Ciudad),
                SH.SHValidateExcelString(record.empresa.EmpresaTamaño),
                new CSTipoAE(
                    SH.SHValidateExcelString(string.Empty),
                    SH.SHValidateExcelString(record.empresa.TpActEcono)
                    ));
        }

        public static CSDepEducativa DependenciaExcelToObj(CSMinExcelRowRecord record, CSDepEducativa dependencia)
        {
            if (dependencia == null)
            {
                return new CSDepEducativa(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString("FACULTAD DE INGENIERÍA MECÁNICA Y ELÉCTRICA"),
                SH.SHValidateExcelString(record.estudiante.NivelAcademico),
                SH.SHValidateExcelString("AV. PEDRO DE ALBA S/N, CIUDAD UNIVERSITARIA, C.P. 64451"),
                SH.SHValidateExcelString("FIME")
                );
            }
            else {
                return dependencia;
            }
            
        }

        public static CSDepartamento DepartamentoExcelToObj(CSMinExcelRowRecord record) {
            return new CSDepartamento(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.programa.Deparatmento));
        }

        public static CSTipoPrograma TPExcelToObject(CSMinExcelRowRecord record)
        {
            return new CSTipoPrograma(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.programa.Tipo));

        }

        public static CSComunidad ComunidadExcelToObj(CSMinExcelRowRecord record) {
            return new CSComunidad(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.programa.ComuniadAtend));
        }

        public static CSResponsable ResponsableExcelToObj(CSMinExcelRowRecord record) {

            string[] respData = SH.SHValidateAndDivideExcelString(record.programa.Responsable);

            return new CSResponsable(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(respData[1].ToUpper()),
                SH.SHValidateExcelString(respData[2].ToUpper()),
                SH.SHValidateExcelString(string.Join(" ",respData[3..respData.Length].Select(s => s.ToUpper()))),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                new CSCarrera(
                    SH.SHValidateExcelString(string.Empty),
                    new CSTipoCarrera(
                        0,
                        SH.SHValidateExcelString(string.Empty)),
                    SH.SHValidateExcelString(respData[0].ToUpper())),
                SH.SHValidateExcelString("ACTIVO"),
                SH.SHValidateExcelString("default"),
                SH.SHValidateExcelString("root"),
                Array.Empty<byte>()
                );
        }

        /*
         PENDIENTE PARA ASIGNAR EL COORDINADOR
         */

        public static CSCoordinador CoordinadorExcelToObj(CSCoordinador coordinador) {
            if (coordinador == null)
            {
                return new CSCoordinador(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString("MISSAEL ANTONIO"),
                SH.SHValidateExcelString("GUEVARA"),
                SH.SHValidateExcelString("CORREA"),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                new CSCarrera(
                    SH.SHValidateExcelString(string.Empty),
                    new CSTipoCarrera(
                        0,
                        SH.SHValidateExcelString(string.Empty)),
                    SH.SHValidateExcelString("M.A.")),
                SH.SHValidateExcelString("ACTIVO"),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty),
                Array.Empty<byte>(),
                Array.Empty<byte>()
                );
            }
            else {
                return coordinador;
            }
            
        }

        public static CSAlumno AlumnoExcelToObj(CSMinExcelRowRecord record) {

            string[] respData = SH.SHValidateAndDivideExcelString(record.programa.Responsable);

            return new CSAlumno(
                SH.SHValidateExcelString(record.estudiante.Matricula),
                SH.SHValidateExcelString(record.estudiante.Nombre),
                SH.SHValidateExcelString(record.estudiante.APaterno),
                SH.SHValidateExcelString(record.estudiante.AMaterno),
                SH.SHValidateExcelString(record.estudiante.EmailUANL),
                SH.SHValidateExcelString(record.estudiante.EmailPersonal),
                SH.SHValidateExcelString(record.estudiante.Telefono),
                SH.SHValidateExcelString(record.estudiante.NivelAcademico),
                new CSCarrera(
                    SH.SHValidateExcelString(record.estudiante.Carrera),
                    new CSTipoCarrera(
                        0,
                        SH.SHValidateExcelString(record.estudiante.NivelAcademico)),
                    SH.SHValidateExcelString(record.estudiante.CarreaAbrev)),
                SH.SHValidateExcelString(record.estudiante.SituacionSS),
                SH.SHValidateExcelString(record.estudiante.Matricula)
                );
        }

        public static CSTurno TurnoExcelToObj(CSMinExcelRowRecord record) {

            return new CSTurno(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.programa.Turno),
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(string.Empty)
                );
        }

        public static CSActividad ActividadExcelToObj(CSMinExcelRowRecord record) {
            return new CSActividad(
                SH.SHValidateExcelString(string.Empty),
                SH.SHValidateExcelString(record.programa.Actividad),
                new CSTipoAE(
                    SH.SHValidateExcelString(string.Empty),
                    SH.SHValidateExcelString(record.programa.Tipo))
                );
        }

        public static CSPeriodo PeriodoExcelToObj(CSPeriodo periodo) {
            if (periodo == null)
            {
                Random rd = new Random();

                return new CSPeriodo(
                    0,
                    SH.SHValidateExcelString("ENERO - JUNIO 2021"),
                    new DateOnly(2020, 12, 1),
                    new DateOnly(2021, 5, 31),
                    new DateTime(2020, 11, rd.Next(21, 28), rd.Next(8,19), rd.Next(0,60), rd.Next(0,60)),
                    new DateTime[] {
                        new DateTime(2020,12, rd.Next(26,32), rd.Next(12,19), rd.Next(0,60), rd.Next(0,60)),
                        new DateTime(2021,1,rd.Next(26,32), rd.Next(8,23), rd.Next(0,60), rd.Next(0,60)),
                        new DateTime(2021,2,rd.Next(24,29), rd.Next(8,23), rd.Next(0,60), rd.Next(0,60)),
                        new DateTime(2021,3,rd.Next(26,32), rd.Next(8,23), rd.Next(0,60), rd.Next(0,60)),
                        new DateTime(2021,4,rd.Next(24,31), rd.Next(8,23), rd.Next(0,60), rd.Next(0,60)),
                        new DateTime(2021,5,rd.Next(26,32), rd.Next(8,23), rd.Next(0,60), rd.Next(0,60))
                    }
                    );
            }
            else {
                return periodo;
            }
            
        }
    }
}
