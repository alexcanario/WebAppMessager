using Dapper;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebAppMessager.Business.Interfaces;

using WebAppMessager.Business.Models;

namespace WebAppMessager.Data.Repositories {
    public class LeituraRepository : Repository<Leitura>, ILeituraRepository {
        
        public LeituraRepository(IConfiguration configuration) : base(configuration) { }

        private string _sqlGetAllLeituras = @"select    l.Id
                                                        ,l.DataLeitura
                                                        ,d.CodigoHidrometro
                                                        ,d.LeituraAnterior
                                                        ,d.LeituraAtual
                                                from Leituras as l inner join LeiturasDetalhe as d on d.LeituraId = l.Id";

        private string _sqlGetAllLeiturasByPeriod = @"select  l.Id
                                                            ,l.DataLeitura
                                                            ,d.CodigoHidrometro
                                                            ,d.LeituraAnterior
                                                            ,d.LeituraAtual
                                                      from Leituras as l inner join LeiturasDetalhe as d on d.LeituraId = l.Id
                                                     where l.DataLeitura between @initialDate and @finalDate";

        private string _sqlDefault = @"select getdate();";

        public async Task<IEnumerable<ILeitura>> GetAll() {
            try {
                using var con = new SqlConnection(_connectionString);
                var data = con.Query<DateTime>(_sqlDefault);
                var leituras = await con.QueryAsync<ILeitura>(_sqlGetAllLeituras);
                return leituras;
            } catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<ILeitura>> GetByPeriod(Period periodo) {
            using var con = new SqlConnection(_connectionString);
            var leituras = await con.QueryAsync<ILeitura>(_sqlGetAllLeiturasByPeriod, new { initialDate = periodo.InitialDate, finalDate = periodo.FinalDate });
            return leituras;
        }
    }
}
