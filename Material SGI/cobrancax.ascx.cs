using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cobranca_Cobrancax : System.Web.UI.UserControl
{
    Funcoes func = new Funcoes();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string vHabilita = "";
            string vTopNegrito = "";
            string vNovoItem = "";
            Funcoes func = new Funcoes();
            int[] funcoesAcesso = func.PegaArrayAcessosUsuario(Session["UsuarioAtual"].ToString());
            int[] funcoesTopAce = func.PegaArrayTopFuncoesUsuario(Session["UsuarioAtual"].ToString());
            int vMaxFuncao = Convert.ToInt32(func.PegaCampoPorSQL("select max(cd_funcao)-20 V_AUX from ca_funcao"));

            string vDadosFunc = func.PegaCampoPorSQL("select rtrim(lower(nm_guerra)) v_aux from funcionario where cd_pessoa = " + HttpContext.Current.Session["UsuarioAtual"].ToString()) +
                        " - " + func.PegaCampoPorSQL("select rtrim(lower(s.ds_setor)) v_aux from funcionario f, setor s where f.cd_setor = s.cd_setor and f.cd_pessoa = " + HttpContext.Current.Session["UsuarioAtual"].ToString()) +
                        " - banco: " + func.PegaCampoPorSQL("select db_name() V_AUX");
            string vImgFun = "http://www.sj.com.br/DocTrocaTitEnergia/FotosColaboradores/" + HttpContext.Current.Session["UsuarioAtual"].ToString() + ".jpg";
            //if (!File.Exists(vImgFun))
            //    vImgFun = "http://www.sj.com.br/appsgi/imagens/desconhecido.jpg";

            StringBuilder sb = new StringBuilder();
            sb.Append("<nav class='navbar navbar-expand-lg navbar-light '  style='background-color: #DADCE0;' >");
            sb.Append("<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#conteudoNavbarSuportado' aria-controls='conteudoNavbarSuportado' aria-expanded='false' aria-label='Alterna navegação'>");
            sb.Append("     <span class='navbar-toggler-icon'></span>");
            sb.Append("</button>");
            sb.Append("<a class='navbar-brand' href='#'>DH</a>");
            sb.Append("<div class='collapse navbar-collapse' id='conteudoNavbarSuportado'>");
            sb.Append("<ul class='navbar-nav mr-auto'>");
            sb.Append("      <li class='nav-item active py-1 '>");
            if (Session["EmpresaAtual"].ToString() == "1" || Session["EmpresaAtual"].ToString() == "2" || Session["EmpresaAtual"].ToString() == "3" || Session["EmpresaAtual"].ToString() == "4" || Session["EmpresaAtual"].ToString() == "5" || Session["EmpresaAtual"].ToString() == "8" || Session["EmpresaAtual"].ToString() == "9")
                sb.Append(" <a class='navbar-brand' href='../../default.aspx'><img src = '../../Imagens/logohome.png'   alt='' ></a>");
            if (Session["EmpresaAtual"].ToString() == "6")
                sb.Append(" <a class='navbar-brand' href='../../defaultBlokus.aspx'><img src = '../../Imagens/logohome.png'   alt='' ></a>");
            if (Session["EmpresaAtual"].ToString() == "7")
                sb.Append(" <a class='navbar-brand' href='../../defaultVerdeGreen.aspx'><img src = '../../Imagens/logohome.png'   alt='' ></a>");
            if (Session["EmpresaAtual"].ToString() == "19")
                sb.Append(" <a class='navbar-brand' href='../../defaultReadi.aspx'><img src = '../../Imagens/logohome.png'   alt='' ></a>");
            //sb.Append("        <a class='nav-link' href='/default.aspx'>Início <span class='sr-only'>(página atual)</span></a>");
            sb.Append("      </li>");
            /*sb.Append("      <li class='nav-item'>");
            sb.Append("        <a class='nav-link' href='#'>Link</a>");
            sb.Append("      </li>");*/



            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Cobranças");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 787)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 787)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (787 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='recibos_vencidos.aspx'>Recibos Vencidos" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 247)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 247)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (247 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_graficos_cobranca.aspx'>Acompanhamento de Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 255)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 255)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (255 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cartas_cobranca.aspx'>Cartas de Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 814)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 814)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (814 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cartas_cobranca.aspx'>Acordo Cobrança - Cadastro" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 825)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 825)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (825 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='acordo_cobranca_remessa.aspx'>Acordo Cobrança - Boletos" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1171)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1171)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1171 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='acordo_especial_inadimplencia2019.aspx'>Acordo Especial 2019" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 920)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 920)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (920 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='demonstrativo_acao.aspx'>Demonstrativo Ação" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 924)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 924)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (924 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='demonstrativo_pagamento.aspx'>Demonstrativo Pagamento" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 826)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 826)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (826 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='recebimento_cobranca.aspx'>Recebimento Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 896)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 896)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (896 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='termometro_honorario_cobranca.aspx'>Termômetro Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 320)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 320)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (320 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='atualizacao_cart_cob_1_mes.aspx'>Atualização Carteira Cobrança de Contratos com 1 Mês Vencido" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 921)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 921)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (921 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pend_recebimento_cheque_devolvido.aspx'>Pendências de Recebimento de Cheque Devolvido" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 1043)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1043)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1043 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='gerenciamento_processo_cobranca.aspx'>GPC - Gestão Processos Cobrança" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");


            if (!funcoesAcesso.Any(x => x == 854)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 854)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (854 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='honorarios_remuneracao_carteiras.aspx'>Honorário Remunaração Carteira" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 870)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 870)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (870 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='controle_honorarios_envio.aspx'>Controle de Honorários - Envio" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 916)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 916)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (916 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='controle_carteira_cobranca.aspx'>Controle Carteira Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1125)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1125)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1125 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='ranking_colaboradores.aspx'>Ranking dos Colaboradores" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 179)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 179)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (179 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='exoneracao_fianca.aspx'>Processo de Exoneração de Fiança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 856)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 856)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (856 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_notas_cobranca.aspx'>Notas de Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 880)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 880)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (880 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='negativacao_spc_serasa.aspx'>Negativação SPC/SERASA" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 894)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 894)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (894 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_clientes_duvidosos.aspx'>Cadastro de Clientes Duvidosos" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 903)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 903)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (903 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='Controle de CI.aspx'>Controle de CI" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 915)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 915)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (915 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='validacao_cobranca.aspx'>Auditoria Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1264)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1264)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1264 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='acomp_contrato_rescindo_com_acao.aspx'>Acompanhamento Contrato Rescindido com Ação" + vNovoItem + "</a>");

            sb.Append("        </div>");
            sb.Append("      </li>");

            // Segunda Aba

            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Contrato");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 126)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 126)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (126 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='Abrir Contrato" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 252)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 252)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (252 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='carta_processo_majoracao_sj.aspx'>Carta do Processo de Majoração" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 488)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 488)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (488 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='contratos_inviaveis_cobranca.aspx'>Contratos Inviáveis para Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 492)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 492)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (492 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pend_aprovacao_contratos_inviaveis_cobranca.aspx'>Contratos Inviáveis para Cobrança - Pendentes para Aprovação" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 493)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 493)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (493 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pend_baixa_contratos_inviaveis_cobranca.aspx'>Contratos Inviáveis para Cobrança - Pendentes para Baixa" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 494)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 494)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (494 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pend_conclusao_contratos_inviaveis_cobranca.aspx'>Contratos Inviáveis para Cobrança - Pendentes para Conclusão" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 868)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 868)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (868 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_reg_honor_jur.aspx'>Honorário Jurídico" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 871)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 871)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (871 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_encam_contrato_acao.aspx'>Encaminhamento de Contrato para Ação - Cadastro" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 872)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 872)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (872 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pend_encam_contrato_acao.aspx'>Encaminhamento de Contrato para Ação - Pendências" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1182)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1182)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1182 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pendencias_custo_proc.aspx'>Pendências Autorização Custas Processuais" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1098)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1098)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1098 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pontuacao_ajuizamento_acao.aspx'>Score Ajuizamento Ação" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 883)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 883)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (883 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='ajuizamento_contrato.aspx'>Ajuizamento" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 884)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 884)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (884 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='protesto_titulo.aspx'>Protesto de Título" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1004)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1004)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1004 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_sub_locatario_contrato.aspx'>Contratos com SubLocatário" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 1091)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1091)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1091 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='proc_seguro_fianca.aspx'>Processo Seguro Fiança" + vNovoItem + "</a>");
            sb.Append("        </div>");
            sb.Append("      </li>");

            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Recibo");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 286)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 286)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (286 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='consulta_recibo.aspx'>Consultar Recibo" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 919)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 919)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (919 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='emissao_boleto_recibo.aspx'>Emissão Boleto" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1196)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1196)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1196 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_desconto_recibo_repassado.aspx'>Desconto Especial Recibo de Inquilino com Extrato Pago" + vNovoItem + "</a>");
            sb.Append("        </div>");
            sb.Append("      </li>");

            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Proprietário");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 1184)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1184)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1184 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='proc_cobranca_prop.aspx'>Cobrança Proprietário" + vNovoItem + "</a>");
            sb.Append("        </div>");
            sb.Append("      </li>");

            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Samir");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 888)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 888)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (888 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='controle_titulos_samir.aspx'>Controle de Títulos SAMIR" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1098)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1098)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1098 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='pontuacao_ajuizamento_acao.aspx'>Score Ajuizamento Ação" + vNovoItem + "</a>");
            sb.Append("        </div>");
            sb.Append("      </li>");
           


            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Relatório");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 250)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 250)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (250 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_contratos_vencidos_por_garantia.aspx'>Contratos Vencidos por Garantia" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 248)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 248)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (248 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_historico_distribuicao_carteira_cobranca.aspx'>Histórico de Distribuição de Carteira Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 249)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 249)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (249 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_proc_majoracao_sj.aspx'>Processos de Majoração" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 246)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 246)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (246 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_contatos_cobranca.aspx'>Histórico de Contato de Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 308)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 308)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (308 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_cob_spc_serasa_tit_prot.aspx'>Negativação SPC/SERASA e Títulos Protestados" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 368)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 368)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (368 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_posicao_cobranca_sj.aspx'>Posição de Cobrança SJ" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 410)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 410)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (410 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_pesquisa_satisfacao_cobranca.aspx'>Pesquisa Satisfação Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 513)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 513)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (513 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acomp_cob_prop.aspx'>Histórico de Cobrança para Proprietário" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 598)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 598)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (598 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_contatos_cobr_per.aspx'>Contatos de Cobrança no Período" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 704)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 704)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (704 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acomp_cob_pos.aspx'>Acompanhamento de Cobrança por Posição" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 746)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 746)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (746 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acordos_bol_venc.aspx'>Acordos com Boleto Vencido" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 748)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 748)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (748 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_contr_com_nota_venc_mes.aspx'>Contratos com nota 1 e com Boleto Vencido" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 873)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 873)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (873 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_encam_contrato_acao.aspx'>Encaminhamento de Contrato para Ação" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 876)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 876)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (876 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='planilha_calculo.aspx'>Planilha Manual de Cálculo" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 933)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 933)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (933 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_correcao_monetaria.aspx'>Correção Monetária" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1002)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1002)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1002 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_recebimentos_diario.aspx'>Recebimentos Diários" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 1006)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1006)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1006 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acomp_outros_debitos.aspx'>Acompanhamento de Cobrança - Outros Débitos" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 1170)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1170)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1170 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acordo_samir_digital.aspx'>Acordo Samir Digital" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1173)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1173)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1173 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_acordo_especial.aspx'>Acordo Especial 2019" + vNovoItem + "</a>");

            sb.Append("          <div class='dropdown-divider'></div>");

            if (!funcoesAcesso.Any(x => x == 756)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 756)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (756 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_dinamico_cobranca_sj.aspx'>Cobrança - Dinâmico" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 993)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 993)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (993 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='rel_valores_recebidos_cobranca_periodo.aspx'>Valores Recebidos pela Cobrança" + vNovoItem + "</a>");
            sb.Append("        </div>");
            sb.Append("      </li>");

            sb.Append("      <li class='nav-item dropdown'>");
            sb.Append("        <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
            sb.Append("         &nbsp;&nbsp;Configurações");
            sb.Append("        </a>");
            sb.Append("        <div class='dropdown-menu' aria-labelledby='navbarDropdown'>");
            if (!funcoesAcesso.Any(x => x == 606)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 606)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (606 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='ajuste_qtd_min_dias_cont_cob.aspx'>Ajuste de Quantidade Mínima de Dias para Contato com Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 910)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 910)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (910 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_percentuais_comissao.aspx'>Cadastro de Percentuais de Remuneração Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 913)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 913)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (913 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='cad_valores_remuneracao_mensal_juridico.aspx'>Cadastro de Valores Mensal Remuneração Jurídico" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1076)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1076)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1076 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='redutor_comissao_cobranca.aspx'>Ajuste Comissão Cobrança" + vNovoItem + "</a>");
            if (!funcoesAcesso.Any(x => x == 1124)) vHabilita = " disabled "; else vHabilita = "";
            if (funcoesTopAce.Any(x => x == 1124)) vTopNegrito = " font-weight-bold "; else vTopNegrito = "";
            if (1124 > vMaxFuncao) vNovoItem = "<sup>novo<sup>"; else vNovoItem = "";
            sb.Append("          <a class='dropdown-item " + vTopNegrito + vHabilita + "' href='registro_ligacoes_tel.aspx'>Ligações Telefônicas" + vNovoItem + "</a>");

            sb.Append("        </div>");
            sb.Append("      </li>");


            sb.Append("      <li class='nav-item'>");
            sb.Append(" <a class='nav-link disabled' href='#'>&nbsp;&nbsp;&nbsp;</a>");
            sb.Append("      </li>");
            sb.Append("<li class='nav-item align-bottom  py-1'>");
            sb.Append(" <a class='navbar-brand align-bottom' href='../../Comum/cad_imovel.aspx' target='_blank' tooltipo='imóvel'>");
            sb.Append("    <img src = '../../Imagens/mnimovelx.png'   alt='' >");
            sb.Append("  </a>");
            sb.Append(" <a class='navbar-brand' href='../../Comum/cad_contrato.aspx' target='_blank'>");
            sb.Append("    <img src = '../../Imagens/mncontratox.png'   alt='' >");
            sb.Append("  </a>");
            sb.Append(" <a class='navbar-brand' href='../../Comum/cad_proprietario.aspx' target='_blank'>");
            sb.Append("    <img src = '../../Imagens/mnproprietariox.png'   alt='' >");
            sb.Append("  </a>");
            sb.Append(" <a class='navbar-brand' href='../../Tesouraria/Paginas/consulta_recibo.aspx' target='_blank'>");
            sb.Append("    <img src = '../../Imagens/mnrecibox.png'   alt='' >");
            sb.Append("  </a>");
            sb.Append("</li>");
            sb.Append(" <a class='navbar-brand' href='#'>");
            sb.Append("    <img src = '" + vImgFun + "' width='30' height='30' alt='' title='" + vDadosFunc + "' class='rounded'>");
            sb.Append("  </a>");
            sb.Append("    </ul>");
            /*sb.Append("    <form class='form-inline my-2 my-lg-0'>");
            sb.Append(" <input class='form-control mr-sm-2' type='search' placeholder='Pesquisar' aria-label='Pesquisar'>");
            sb.Append("      <button class='btn btn-outline-success my-2 my-sm-0' type='submit'>Pesquisar</button>");
            sb.Append("    </form>");*/
            sb.Append("  </div>");
            sb.Append("</nav>");
            myNav.InnerHtml = sb.ToString();



        }
    }
}