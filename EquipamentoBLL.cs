using ClassErro;
using System.Data;

namespace Desafio_AD_BD
{
    internal class EquipamentoBLL
    {
        // ================= CADASTRAR =================

        public void CadastrarEquipamento(Equipamentos equipamento)
        {
            ValidarCamposEquipamento(equipamento);

            if (Erro.getErro())
                return;

            EquipamentoDAL.InserirEquipamento(equipamento);
        }

        // ================= CONSULTAR =================

        public DataTable ConsultarEquipamento(Equipamentos equipamento)
        {
            ValidarPatrimonio(equipamento);

            if (Erro.getErro())
                return null;

            return EquipamentoDAL.ConsultarEquipamentoPorPatrimonio(equipamento);
        }

        // ================= ATUALIZAR =================

        public void AtualizarEquipamento(Equipamentos equipamento)
        {
            ValidarCamposEquipamento(equipamento);

            if (Erro.getErro())
                return;

            if (!EquipamentoDAL.PatrimonioExiste(equipamento.Patrimonio))
            {
                Erro.setMsg("Nenhum equipamento encontrado com este patrimônio.");
                return;
            }

            EquipamentoDAL.AtualizarEquipamento(equipamento);
        }

        // ================= EXCLUIR =================

        public void ExcluirEquipamento(Equipamentos equipamento)
        {
            ValidarPatrimonio(equipamento);

            if (Erro.getErro())
                return;

            if (!EquipamentoDAL.PatrimonioExiste(equipamento.Patrimonio))
            {
                Erro.setMsg("Nenhum equipamento encontrado com este patrimônio.");
                return;
            }

            EquipamentoDAL.ExcluirEquipamento(equipamento);
        }

        // ================= PEÇAS =================

        public void ValidarNovaPeca(string novaPeca)
        {
            Erro.setErro(false);

            if (novaPeca.Trim() == "")
            {
                Erro.setMsg("Informe o nome da peça.");
                return;
            }
        }

        // ================= VALIDAÇÕES =================

        private void ValidarPatrimonio(Equipamentos equipamento)
        {
            Erro.setErro(false);

            equipamento.Patrimonio = equipamento.Patrimonio?.Trim();

            if (string.IsNullOrWhiteSpace(equipamento.Patrimonio))
            {
                Erro.setMsg("O patrimônio é obrigatório.");
                return;
            }
        }

        private void ValidarCamposEquipamento(Equipamentos equipamento)
        {
            Erro.setErro(false);

            equipamento.Local = equipamento.Local?.Trim();
            equipamento.Fabricante = equipamento.Fabricante?.Trim();
            equipamento.Modelo = equipamento.Modelo?.Trim();
            equipamento.Patrimonio = equipamento.Patrimonio?.Trim();

            if (string.IsNullOrWhiteSpace(equipamento.Local))
            {
                Erro.setMsg("O local é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(equipamento.Fabricante))
            {
                Erro.setMsg("O fabricante é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(equipamento.Modelo))
            {
                Erro.setMsg("O modelo é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(equipamento.Patrimonio))
            {
                Erro.setMsg("O patrimônio é obrigatório.");
                return;
            }

            if (equipamento.Pecas == null || equipamento.Pecas.Count == 0)
            {
                Erro.setMsg("Selecione pelo menos uma peça.");
                return;
            }
        }
    }
}
