using devindocuments;



static int Menu()
{
    Console.Clear();

    Funcionario funcionario1 = new Funcionario(codigo: "01", nome: "Gabriel Fernandes",
                                endereco: "Rua Nossa Senhora de Nazare 284", dataNascimento: "1997, 07, 01", filiacao: "EDP", dataAdmissao: new DateTime(2022, 11, 01));

    Console.WriteLine($"Olá, {funcionario1.getNome()}");
    Console.WriteLine("Bem Vindo ao DevInDocuments!");
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Para cadastrar uma nota");
    Console.WriteLine("2 - Listagem de documentos");
    Console.WriteLine("3 - Editar documentos");
    Console.WriteLine("4-  Alterar status do documento");
    Console.WriteLine("5 - Relatórios");
    Console.WriteLine("6 - Sair do programa");
    int opcao = Convert.ToInt32(Console.ReadLine());
    return opcao;
}




NotaFiscal exemploNota = new NotaFiscal(0, "000", DateTime.Now, "Farmacia", "XXXXXXX", 0, 1000, "Medicamentos", 0, 100);
exemploNota.AdicionaLista(exemploNota);




int contadorID = 0;



int opcao = 0;
while (opcao != 6)
{
    opcao = Menu();
    Console.Clear();

    switch (opcao)
    {
        case 1:

            int op = 0;

            Console.WriteLine($"Selecione o tipo de nota a ser cadastrada: \n");
            Console.WriteLine($"0 - Nota Fiscal");
            Console.WriteLine($"1 - Licenças de Funcionamento");
            Console.WriteLine($"2 - Contrato");
            op = int.Parse(Console.ReadLine());
            if (op == (int)OpcoesTipo.Nota_Fiscal)
            {

                string data, estabelecimento, cnpj, nomeProduto;
                int opStatus = 0, status = 0, opTipoImposto = 0, tipoImposto = 0;
                double valorTotal, valorTotalImposto;
                DateTime dataAlteracao = DateTime.Now;

                Console.WriteLine("Informe a data do cadastro:");
                data = Console.ReadLine();


                Console.WriteLine("Informe o nome do estabelecimento:");
                estabelecimento = Console.ReadLine();


                Console.WriteLine("Informe o CNPJ da empresa:");
                cnpj = Console.ReadLine();

                Console.WriteLine("Informe o status do documento:");
                Console.WriteLine($"0 - Ativo");
                Console.WriteLine($"1 - Em tramitação");
                Console.WriteLine($"2 - Suspenso");
                opStatus = int.Parse(Console.ReadLine());

                while (opStatus != (int)StatusDocumento.Ativo && opStatus != (int)StatusDocumento.Tramitando && opStatus != (int)StatusDocumento.Suspenso)
                {
                    Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                    Console.WriteLine("Informe o status do documento:");
                    Console.WriteLine($"0 - Ativo");
                    Console.WriteLine($"1 - Em tramitação");
                    Console.WriteLine($"2 - Suspenso");
                    opStatus = int.Parse(Console.ReadLine());
                }

                if (opStatus == (int)StatusDocumento.Ativo)
                {
                    status = Convert.ToInt32(StatusDocumento.Ativo);
                }

                else if (opStatus == (int)StatusDocumento.Tramitando)
                {
                    status = Convert.ToInt32(StatusDocumento.Tramitando);
                }

                else if (opStatus == (int)StatusDocumento.Suspenso)
                {
                    status = Convert.ToInt32(StatusDocumento.Suspenso);
                }

                Console.WriteLine("Informe o valor total:");
                valorTotal = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do produto:");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Informe o tipo de imposto:");
                Console.WriteLine($"0 - ICMS");
                Console.WriteLine($"1 - IPI");
                Console.WriteLine($"2 - IOF");
                Console.WriteLine($"3 - Outro");
                opTipoImposto = int.Parse(Console.ReadLine());

                while (opTipoImposto != (int)TipoImposto.ICMS && opTipoImposto != (int)TipoImposto.IPI &&
                opTipoImposto != (int)TipoImposto.IOF && opTipoImposto != (int)TipoImposto.Outro)
                {
                    Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                    Console.WriteLine("Informe o tipo de imposto:");
                    Console.WriteLine($"0 - ICMS");
                    Console.WriteLine($"1 - IPI");
                    Console.WriteLine($"2 - IOF");
                    Console.WriteLine($"3 - Outro");
                    opTipoImposto = int.Parse(Console.ReadLine());

                }

                if (opTipoImposto == (int)TipoImposto.ICMS)
                {
                    tipoImposto = Convert.ToInt32(TipoImposto.ICMS);
                }

                else if (opTipoImposto == (int)TipoImposto.IPI)
                {
                    tipoImposto = Convert.ToInt32(TipoImposto.IPI);
                }

                else if (opTipoImposto == (int)TipoImposto.IOF)
                {
                    tipoImposto = Convert.ToInt32(TipoImposto.IOF);
                }

                else if (opTipoImposto == (int)TipoImposto.Outro)
                {
                    tipoImposto = Convert.ToInt32(TipoImposto.Outro);
                }



                Console.WriteLine("Informe o valor total do imposto:");
                valorTotalImposto = double.Parse(Console.ReadLine());

                contadorID = contadorID + 1;






                NotaFiscal nota = new NotaFiscal(CodigoDocumento: contadorID, DataCadastroSistema: data, DataUltimaAlteracao: dataAlteracao, NomeEstabelecimento: estabelecimento,
                                                 CNPJ: cnpj, Status: status, ValorTotal: valorTotal, NomeProduto: nomeProduto, TipoImposto: tipoImposto,
                                                 ValorTotalImposto: valorTotalImposto);

                nota.AdicionaLista(nota);
                Console.WriteLine("\n \n Nota adicionada, pressione enter para voltar ao menu principal...");

                Console.ReadKey();
            }

            else if (op == (int)OpcoesTipo.LicencasFuncionamento)
            {
                string data, estabelecimento, cnpj, endereco;
                int opStatus = 0, status = 0, opAtuacao = 0, areaAtuacao = 0;
                DateTime dataAlteracao = DateTime.Now;


                Console.WriteLine("Informe a data do cadastro:");
                data = Console.ReadLine();


                Console.WriteLine("Informe o nome do estabelecimento:");
                estabelecimento = Console.ReadLine();


                Console.WriteLine("Informe o CNPJ da empresa:");
                cnpj = Console.ReadLine();

                Console.WriteLine("Informe o status do documento:");
                Console.WriteLine($"0 - Ativo");
                Console.WriteLine($"1 - Em tramitação");
                Console.WriteLine($"2 - Suspenso");
                opStatus = int.Parse(Console.ReadLine());

                while (opStatus != (int)StatusDocumento.Ativo && opStatus != (int)StatusDocumento.Tramitando && opStatus != (int)StatusDocumento.Suspenso)
                {
                    Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                    Console.WriteLine("Informe o status do documento:");
                    Console.WriteLine($"0 - Ativo");
                    Console.WriteLine($"1 - Em tramitação");
                    Console.WriteLine($"2 - Suspenso");
                    opStatus = int.Parse(Console.ReadLine());
                }

                if (opStatus == (int)StatusDocumento.Ativo)
                {
                    status = Convert.ToInt32(StatusDocumento.Ativo);
                }

                else if (opStatus == (int)StatusDocumento.Tramitando)
                {
                    status = Convert.ToInt32(StatusDocumento.Tramitando);
                }

                else if (opStatus == (int)StatusDocumento.Suspenso)
                {
                    status = Convert.ToInt32(StatusDocumento.Suspenso);
                }


                Console.WriteLine("Informe o endereço:");
                endereco = Console.ReadLine();

                Console.WriteLine("Informe a área de atuação:");

                while (opAtuacao != (int)AreaAtuacao.Industrial && opAtuacao != (int)AreaAtuacao.Agropecuario &&
                opAtuacao != (int)AreaAtuacao.Metalurgico && opAtuacao != (int)AreaAtuacao.Tecnologia
                && opAtuacao != (int)AreaAtuacao.Outro)
                {
                    Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                    Console.WriteLine("Informe a área de atuação:");
                    Console.WriteLine($"0 - Industrial");
                    Console.WriteLine($"1 - Agropecuario");
                    Console.WriteLine($"2 - Metalurgico");
                    Console.WriteLine($"3 - Tecnologia");
                    Console.WriteLine($"4 - Outro");

                    opAtuacao = int.Parse(Console.ReadLine());

                }

                if (opAtuacao == (int)AreaAtuacao.Industrial)
                {
                    areaAtuacao = Convert.ToInt32(AreaAtuacao.Industrial);
                }

                else if (opAtuacao == (int)AreaAtuacao.Agropecuario)
                {
                    areaAtuacao = Convert.ToInt32(AreaAtuacao.Agropecuario);
                }

                else if (opAtuacao == (int)AreaAtuacao.Metalurgico)
                {
                    areaAtuacao = Convert.ToInt32(AreaAtuacao.Metalurgico);
                }

                else if (opAtuacao == (int)AreaAtuacao.Tecnologia)
                {
                    areaAtuacao = Convert.ToInt32(AreaAtuacao.Tecnologia);
                }

                else if (opAtuacao == (int)AreaAtuacao.Outro)
                {
                    areaAtuacao = Convert.ToInt32(AreaAtuacao.Outro);
                }



                contadorID = contadorID + 1;

                LicencasFuncionamento nota = new LicencasFuncionamento(CodigoDocumento: contadorID, DataCadastroSistema: data, DataUltimaAlteracao: dataAlteracao, NomeEstabelecimento: estabelecimento, CNPJ: cnpj,
                                                                       Status: status, Endereco: endereco, AreaAtuacao: areaAtuacao);
                nota.AdicionaLista(nota);
                Console.WriteLine("\n \n Nota adicionada, pressione enter para voltar ao menu principal...");

                Console.ReadKey();
            }
            else if (op == (int)OpcoesTipo.Contrato)
            {
                string data, estabelecimento, cnpj, finalidade, testesmunhas, dataExpiracao;
                int opStatus = 0, status = 0;
                DateTime dataAlteracao = DateTime.Now;



                Console.WriteLine("Informe a data do cadastro:");
                data = Console.ReadLine();


                Console.WriteLine("Informe o nome do estabelecimento:");
                estabelecimento = Console.ReadLine();


                Console.WriteLine("Informe o CNPJ da empresa:");
                cnpj = Console.ReadLine();

                Console.WriteLine("Informe o status do documento:");
                Console.WriteLine("Informe o status do documento:");
                Console.WriteLine($"0 - Ativo");
                Console.WriteLine($"1 - Em tramitação");
                Console.WriteLine($"2 - Suspenso");
                opStatus = int.Parse(Console.ReadLine());

                while (opStatus != (int)StatusDocumento.Ativo && opStatus != (int)StatusDocumento.Tramitando && opStatus != (int)StatusDocumento.Suspenso)
                {

                    Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                    Console.WriteLine("Informe o status do documento:");
                    Console.WriteLine($"0 - Ativo");
                    Console.WriteLine($"1 - Em tramitação");
                    Console.WriteLine($"2 - Suspenso");
                    opStatus = int.Parse(Console.ReadLine());
                }


                if (opStatus == (int)StatusDocumento.Ativo)
                {
                    status = Convert.ToInt32(StatusDocumento.Ativo);
                }

                else if (opStatus == (int)StatusDocumento.Tramitando)
                {
                    status = Convert.ToInt32(StatusDocumento.Tramitando);
                }

                else if (opStatus == (int)StatusDocumento.Suspenso)
                {
                    status = Convert.ToInt32(StatusDocumento.Suspenso);
                }

                Console.WriteLine("Informe a finalidade:");
                finalidade = Console.ReadLine();

                Console.WriteLine("Informe as testemunhas:");
                testesmunhas = Console.ReadLine();

                Console.WriteLine("Informe a data de expiração:");
                dataExpiracao = Console.ReadLine();

                contadorID = contadorID + 1;

                Contrato nota = new Contrato(CodigoDocumento: contadorID, DataCadastroSistema: data, DataUltimaAlteracao: dataAlteracao, NomeEstabelecimento: estabelecimento,
                                             CNPJ: cnpj, Status: status, Finalidade: finalidade, Testemunhas: testesmunhas, DataExpiracao: dataExpiracao);
                nota.AdicionaLista(nota);
                Console.WriteLine("\n \n Nota adicionada, pressione enter para voltar ao menu principal...");


                Console.ReadKey();
            }

            else if (op != (int)OpcoesTipo.Contrato || op != (int)OpcoesTipo.LicencasFuncionamento || op != (int)OpcoesTipo.Nota_Fiscal)
            {
                Console.WriteLine("\nOpção Invalida, aperte Enter para voltar o menu inicial...");
                Console.ReadKey();
            }

            break;

        case 2:
            {
                int opList = 0;
                Console.WriteLine("Digite a opção:");
                Console.WriteLine("1 -Listar por nota fiscal");
                Console.WriteLine("2 -Listar por licenças de funcionamento");
                Console.WriteLine("3 -Listar por contrato");
                Console.WriteLine("4 -Listar todos os documentos");
                opList = int.Parse(Console.ReadLine());

                while (opList != 1 && opList != 2 && opList != 3 && opList != 4)
                {
                    Console.WriteLine("Opção Invalida, escolha uma das opções abaixo:");
                    Console.WriteLine("1 -Listar por nota fiscal");
                    Console.WriteLine("2 -Listar por licenças de funcionamento");
                    Console.WriteLine("3 -Listar por contrato");
                    Console.WriteLine("4 -Listar todos os documentos");
                    opList = int.Parse(Console.ReadLine());
                }

                if (opList == 1)
                {
                    Console.WriteLine($"Documento Cadastrado do Tipo: Nota Fiscal");
                    Console.WriteLine($"Numero total de documentos do Tipo Nota Fiscal: {Lists.NotaFiscal.Count}\n");
                    foreach (var n in Lists.NotaFiscal)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");

                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }
                        Console.WriteLine($"Valor Total: {n.ValorTotal}");

                        Console.WriteLine($"Nome do Produto: {n.NomeProduto}");

                        if (Convert.ToInt32(n.TipoImposto) == 0)
                        {
                            Console.WriteLine($"Tipo de Imposto: ICMS");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 1)
                        {
                            Console.WriteLine($"Tipo de Imposto: IPI");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 2)
                        {
                            Console.WriteLine($"Tipo de Imposto: IOF");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 3)
                        {
                            Console.WriteLine($"Tipo de Imposto: Outros");
                        }
                        Console.WriteLine($"Valor Total do Imposto: {n.ValorTotalImposto} \n \n");
                    }

                }

                else if (opList == 2)
                {
                    Console.WriteLine($"Documento Cadastrado do Tipo: Licenças de Funcionamento");
                    Console.WriteLine($"Numero total de documentos do Tipo Licenças de Funcionamento: {Lists.Licencas.Count}\n");
                    foreach (var n in Lists.Licencas)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");

                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }

                        Console.WriteLine($"Endereço do Estabelecimento: {n.Endereco}");

                        if (Convert.ToInt32(n.AreaAtuacao) == 0)
                        {
                            Console.WriteLine($"Área de Atuação: : Industrial");
                        }
                        if (Convert.ToInt32(n.AreaAtuacao) == 1)
                        {
                            Console.WriteLine($"Área de Atuação: : Agropecuario");
                        }
                        if (Convert.ToInt32(n.AreaAtuacao) == 2)
                        {
                            Console.WriteLine($"Área de Atuação: : Metalurgico");
                        }
                        if (Convert.ToInt32(n.AreaAtuacao) == 3)
                        {
                            Console.WriteLine($"Área de Atuação: : Tecnologia");
                        }
                        if (Convert.ToInt32(n.AreaAtuacao) == 4)
                        {
                            Console.WriteLine($"Área de Atuação: : Outro");
                        }

                    }
                }

                else if (opList == 3)
                {
                    Console.WriteLine($"Documento Cadastrado do Tipo: Contrato");
                    Console.WriteLine($"Numero total de documentos do Tipo Contrato Cadastrado: {Lists.Contrato.Count}\n");
                    foreach (var n in Lists.Contrato)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");
                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }
                        Console.WriteLine($"Finalidade: {n.Finalidade}");
                        Console.WriteLine($"Testemunhas: {n.Testemunhas}");
                        Console.WriteLine($"Testemunhas: {n.DataExpiracao} \n \n");
                    }

                }

                else if (opList == 4)
                {
                    Console.WriteLine($"Documento Cadastrado do Tipo: Nota Fiscal");
                    Console.WriteLine($"Numero total de documentos do Tipo Nota Fiscal: {Lists.NotaFiscal.Count}\n");
                    foreach (var n in Lists.NotaFiscal)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");
                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }
                        Console.WriteLine($"Valor Total: {n.ValorTotal}");

                        Console.WriteLine($"Nome do Produto: {n.NomeProduto}");

                        if (Convert.ToInt32(n.TipoImposto) == 0)
                        {
                            Console.WriteLine($"Tipo de Imposto: ICMS");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 1)
                        {
                            Console.WriteLine($"Tipo de Imposto: IPI");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 2)
                        {
                            Console.WriteLine($"Tipo de Imposto: IOF");
                        }
                        if (Convert.ToInt32(n.TipoImposto) == 3)
                        {
                            Console.WriteLine($"Tipo de Imposto: Outros");
                        }
                        Console.WriteLine($"Valor Total do Imposto: {n.ValorTotalImposto} \n \n");
                    }

                    Console.WriteLine($"Documento Cadastrado do Tipo: Licenças de Funcionamento");
                    Console.WriteLine($"Numero total de documentos do Tipo Licenças de Funcionamento: {Lists.Licencas.Count}\n");
                    foreach (var n in Lists.Licencas)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");
                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }
                        Console.WriteLine($"Endereço do Estabelecimento: {n.Endereco}");
                        Console.WriteLine($"Área de Atuação: {n.AreaAtuacao} \n \n");
                    }

                    Console.WriteLine($"Documento Cadastrado do Tipo: Contrato");
                    Console.WriteLine($"Numero total de documentos do Tipo Contrato Cadastrado: {Lists.Contrato.Count}\n");
                    foreach (var n in Lists.Contrato)
                    {

                        Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                        Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                        Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                        Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                        Console.WriteLine($"CNPJ: {n.CNPJ}");
                        if (Convert.ToInt32(n.Status) == 0)
                        {
                            Console.WriteLine($"Status: Ativo");
                        }
                        if (Convert.ToInt32(n.Status) == 1)
                        {
                            Console.WriteLine($"Status: Em tramitação");
                        }
                        if (Convert.ToInt32(n.Status) == 2)
                        {
                            Console.WriteLine($"Status: Suspenso");
                        }
                        Console.WriteLine($"Finalidade: {n.Finalidade}");
                        Console.WriteLine($"Testemunhas: {n.Testemunhas}");
                        Console.WriteLine($"Testemunhas: {n.DataExpiracao} \n \n");
                    }

                    Console.WriteLine($"Número total de documentos cadastrados: {Lists.NotaFiscal.Count + Lists.Licencas.Count + Lists.Contrato.Count} \n");

                }
                Console.WriteLine("Pressione Enter para voltar ao menu...");
                Console.ReadKey();


            }

            break;


        case 3:

            int opEditDoc = 0, idEdit = 0, editDoc = 0;
            Console.WriteLine("Digite qual documento a ser alterado:");
            Console.WriteLine("1 -Nota fiscal");
            Console.WriteLine("2 -Licenças de funcionamento");
            Console.WriteLine("3 -Contrato");
            opEditDoc = int.Parse(Console.ReadLine());

            while (opEditDoc != 1 && opEditDoc != 2 && opEditDoc != 3)
            {
                Console.WriteLine("Opção Invalida, escolha uma das opções abaixo:");
                Console.WriteLine("1 -Nota fiscal");
                Console.WriteLine("2 -Licenças de funcionamento");
                Console.WriteLine("3 -Contrato");
                opEditDoc = int.Parse(Console.ReadLine());
            }

            if (opEditDoc == 1)
            {
                string dataEdit, estabelecimentoEdit, cnpjEdit, nomeProdutoEdit;
                int opTipoImpostoEdit = 0, tipoImpostoEdit = 0, edStatus = 0;
                double valorTotalEdit, valorTotalImpostoEdit;
                Console.WriteLine("Digite a ID do documento que deseja alterar:");
                idEdit = int.Parse(Console.ReadLine());


                foreach (var e in Lists.NotaFiscal)
                {
                    if (e.CodigoDocumento == idEdit)
                    {
                        Console.WriteLine("Digite a nova data do cadastro:");
                        dataEdit = Console.ReadLine();
                        Console.WriteLine("Digite o novo nome do estabelecimento:");
                        estabelecimentoEdit = Console.ReadLine();
                        Console.WriteLine("Digite o novo CNPJ da empresa:");
                        cnpjEdit = Console.ReadLine();

                        Console.WriteLine("Digite o novo status do documento:");
                        Console.WriteLine($"0 - Ativo");
                        Console.WriteLine($"1 - Em tramitação");
                        Console.WriteLine($"2 - Suspenso");
                        edStatus = int.Parse(Console.ReadLine());
                        while (edStatus != (int)StatusDocumento.Ativo && edStatus != (int)StatusDocumento.Tramitando && edStatus != (int)StatusDocumento.Suspenso)
                        {
                            Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                            Console.WriteLine("Informe o status do documento:");
                            Console.WriteLine($"0 - Ativo");
                            Console.WriteLine($"1 - Em tramitação");
                            Console.WriteLine($"2 - Suspenso");
                            editDoc = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Digite o novo valor total:");
                        valorTotalEdit = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o novo nome do produto:");
                        nomeProdutoEdit = Console.ReadLine();

                        Console.WriteLine("Digite o novo tipo de imposto:");
                        Console.WriteLine($"0 - ICMS");
                        Console.WriteLine($"1 - IPI");
                        Console.WriteLine($"2 - IOF");
                        Console.WriteLine($"3 - Outro");
                        opTipoImpostoEdit = int.Parse(Console.ReadLine());

                        while (opTipoImpostoEdit != (int)TipoImposto.ICMS && opTipoImpostoEdit != (int)TipoImposto.IPI &&
                        opTipoImpostoEdit != (int)TipoImposto.IOF && opTipoImpostoEdit != (int)TipoImposto.Outro)
                        {
                            Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                            Console.WriteLine("Informe o tipo de imposto:");
                            Console.WriteLine($"0 - ICMS");
                            Console.WriteLine($"1 - IPI");
                            Console.WriteLine($"2 - IOF");
                            Console.WriteLine($"3 - Outro");
                            opTipoImpostoEdit = int.Parse(Console.ReadLine());

                        }

                        Console.WriteLine("Informe o valor total do imposto:");
                        valorTotalImpostoEdit = double.Parse(Console.ReadLine());

                        Lists.NotaFiscal[idEdit].DataCadastroSistema = dataEdit;
                        Lists.NotaFiscal[idEdit].NomeEstabelecimento = estabelecimentoEdit;
                        Lists.NotaFiscal[idEdit].CNPJ = cnpjEdit;
                        Lists.NotaFiscal[idEdit].Status = editDoc;
                        Lists.NotaFiscal[idEdit].ValorTotal = valorTotalEdit;
                        Lists.NotaFiscal[idEdit].NomeProduto = nomeProdutoEdit;
                        Lists.NotaFiscal[idEdit].TipoImposto = tipoImpostoEdit;
                        Lists.NotaFiscal[idEdit].ValorTotalImposto = valorTotalImpostoEdit;
                        Lists.NotaFiscal[idEdit].DataUltimaAlteracao = DateTime.Now;


                    }
                }
                Console.WriteLine("Status da nota alterado com sucesso");
            }

            if (opEditDoc == 2)
            {
                string dataEdit, estabelecimentoEdit, cnpjEdit, enderecoEdit;
                int opAtuacaoEdit = 0, edStatus = 0, areaAtuacaoEdit = 0;

                Console.WriteLine("Digite a ID do documento que deseja alterar:");
                idEdit = int.Parse(Console.ReadLine());


                foreach (var e in Lists.Licencas)
                {
                    if (e.CodigoDocumento == idEdit)
                    {
                        Console.WriteLine("Digite a nova data do cadastro:");
                        dataEdit = Console.ReadLine();
                        Console.WriteLine("Digite o novo nome do estabelecimento:");
                        estabelecimentoEdit = Console.ReadLine();
                        Console.WriteLine("Digite o novo CNPJ da empresa:");
                        cnpjEdit = Console.ReadLine();

                        Console.WriteLine("Digite o novo status do documento:");
                        Console.WriteLine($"0 - Ativo");
                        Console.WriteLine($"1 - Em tramitação");
                        Console.WriteLine($"2 - Suspenso");
                        edStatus = int.Parse(Console.ReadLine());
                        while (edStatus != (int)StatusDocumento.Ativo && edStatus != (int)StatusDocumento.Tramitando && edStatus != (int)StatusDocumento.Suspenso)
                        {
                            Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                            Console.WriteLine("Informe o status do documento:");
                            Console.WriteLine($"0 - Ativo");
                            Console.WriteLine($"1 - Em tramitação");
                            Console.WriteLine($"2 - Suspenso");
                            editDoc = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Digite o novo endereço:");
                        enderecoEdit = Console.ReadLine();

                        Console.WriteLine("Informe a área de atuação:");

                        while (opAtuacaoEdit != (int)AreaAtuacao.Industrial && opAtuacaoEdit != (int)AreaAtuacao.Agropecuario &&
                        opAtuacaoEdit != (int)AreaAtuacao.Metalurgico && opAtuacaoEdit != (int)AreaAtuacao.Tecnologia
                        && opAtuacaoEdit != (int)AreaAtuacao.Outro)
                        {
                            Console.WriteLine("Opção Invalida digite uma das opçoes informadas:");
                            Console.WriteLine("Informe a área de atuação:");
                            Console.WriteLine($"0 - Industrial");
                            Console.WriteLine($"1 - Agropecuario");
                            Console.WriteLine($"2 - Metalurgico");
                            Console.WriteLine($"3 - Tecnologia");
                            Console.WriteLine($"4 - Outro");

                            opAtuacaoEdit = int.Parse(Console.ReadLine());

                        }

                        Lists.Licencas[idEdit].DataCadastroSistema = dataEdit;
                        Lists.Licencas[idEdit].NomeEstabelecimento = estabelecimentoEdit;
                        Lists.Licencas[idEdit].CNPJ = cnpjEdit;
                        Lists.Licencas[idEdit].Status = editDoc;
                        Lists.Licencas[idEdit].Endereco = enderecoEdit;
                        Lists.Licencas[idEdit].AreaAtuacao = areaAtuacaoEdit;
                        Lists.Licencas[idEdit].DataUltimaAlteracao = DateTime.Now;

                    }
                    Console.WriteLine("Status da nota alterado com sucesso");

                }
            }


            break;

        case 4:

            int opEditStatus = 0, id = 0, editStatus = 0;
            Console.WriteLine("Digite qual tipo de documento o status vai ser alterado:");
            Console.WriteLine("1 -Nota fiscal");
            Console.WriteLine("2 -Licenças de funcionamento");
            Console.WriteLine("3 -Contrato");
            opEditStatus = int.Parse(Console.ReadLine());

            while (opEditStatus != 1 && opEditStatus != 2 && opEditStatus != 3)
            {
                Console.WriteLine("Opção Invalida, escolha uma das opções abaixo:");
                Console.WriteLine("1 -Nota fiscal");
                Console.WriteLine("2 -Licenças de funcionamento");
                Console.WriteLine("3 -Contrato");
                opEditStatus = int.Parse(Console.ReadLine());
            }

            if (opEditStatus == 1)
            {
                Console.WriteLine("Digite a ID do documento que deseja alterar:");
                id = int.Parse(Console.ReadLine());


                foreach (var e in Lists.NotaFiscal)
                {
                    if (e.CodigoDocumento == id)
                    {
                        Console.WriteLine("Digite o novo status do documento:");
                        editStatus = int.Parse(Console.ReadLine());


                        Lists.NotaFiscal[id].Status = editStatus;
                        Lists.NotaFiscal[id].DataUltimaAlteracao = DateTime.Now;


                    }
                }
                Console.WriteLine("Status da nota alterado com sucesso");
            }

            else if (opEditStatus == 2)
            {
                Console.WriteLine("Digite a ID do documento que deseja alterar:");
                id = int.Parse(Console.ReadLine());


                foreach (var e in Lists.Licencas)
                {
                    if (e.CodigoDocumento == id)
                    {
                        Console.WriteLine("Digite o novo status do documento:");
                        editStatus = int.Parse(Console.ReadLine());


                        Lists.Licencas[id].Status = editStatus;
                        Lists.Licencas[id].DataUltimaAlteracao = DateTime.Now;


                    }
                }

                Console.WriteLine("Status da nota alterado com sucesso");

            }

            else if (opEditStatus == 3)
            {
                Console.WriteLine("Digite a ID do documento que deseja alterar:");
                id = int.Parse(Console.ReadLine());


                foreach (var e in Lists.Contrato)
                {
                    if (e.CodigoDocumento == id)
                    {
                        Console.WriteLine("Digite o novo status do documento:");
                        editStatus = int.Parse(Console.ReadLine());


                        Lists.Contrato[id].Status = editStatus;
                        Lists.Contrato[id].DataUltimaAlteracao = DateTime.Now;


                    }
                }

                Console.WriteLine("Status da nota alterado com sucesso");

            }

            break;


        case 5:

            {
                int contaRelatorio = 0;
                int listarStatus = 0;
                Console.WriteLine("Listagem por status do documento.");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("0 - Ativo");
                Console.WriteLine("1 - Em tramitação");
                Console.WriteLine("2 - Suspenso");
                listarStatus = int.Parse(Console.ReadLine());

                while (listarStatus != 0 && listarStatus != 1 && listarStatus != 2)
                {
                    Console.WriteLine("Opção Invalida, escolha uma das opções abaixo:");
                    Console.WriteLine("Listagem por status do documento.");
                    Console.WriteLine("Digite a opção desejada:");
                    Console.WriteLine("0 - Ativo");
                    Console.WriteLine("1 - Em tramitação");
                    Console.WriteLine("2 - Suspenso");
                    listarStatus = int.Parse(Console.ReadLine());
                }


                if (listarStatus == 0)
                {
                    Console.WriteLine($"----------------- Ativo ------------------------");
                    foreach (var n in Lists.NotaFiscal)
                    {
                        if (n.Status == 0)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Nota Fiscal");
                            contaRelatorio = contaRelatorio + 1;
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Valor Total: {n.ValorTotal}");

                            Console.WriteLine($"Nome do Produto: {n.NomeProduto}");

                            if (Convert.ToInt32(n.TipoImposto) == 0)
                            {
                                Console.WriteLine($"Tipo de Imposto: ICMS");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 1)
                            {
                                Console.WriteLine($"Tipo de Imposto: IPI");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 2)
                            {
                                Console.WriteLine($"Tipo de Imposto: IOF");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 3)
                            {
                                Console.WriteLine($"Tipo de Imposto: Outros");
                            }
                            Console.WriteLine($"Valor Total do Imposto: {n.ValorTotalImposto} \n \n");

                        }

                    }
                    foreach (var n in Lists.Licencas)
                    {
                        if (n.Status == 0)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Licença de Funcionamento.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");

                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }

                            Console.WriteLine($"Endereço do Estabelecimento: {n.Endereco}");

                            if (Convert.ToInt32(n.AreaAtuacao) == 0)
                            {
                                Console.WriteLine($"Área de Atuação: : Industrial");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 1)
                            {
                                Console.WriteLine($"Área de Atuação: : Agropecuario");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 2)
                            {
                                Console.WriteLine($"Área de Atuação: : Metalurgico");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 3)
                            {
                                Console.WriteLine($"Área de Atuação: : Tecnologia");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 4)
                            {
                                Console.WriteLine($"Área de Atuação: : Outro");
                            }
                            Console.WriteLine($"\n");

                        }
                    }

                    foreach (var n in Lists.Contrato)
                    {
                        if (n.Status == 0)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Contrato.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Finalidade: {n.Finalidade}");
                            Console.WriteLine($"Testemunhas: {n.Testemunhas}");
                            Console.WriteLine($"Testemunhas: {n.DataExpiracao} \n \n");
                        }

                    }
                }

                else if (listarStatus == 1)
                {
                    Console.WriteLine($"----------------- Em tramitação ------------------------");
                    foreach (var n in Lists.NotaFiscal)
                    {
                        if (n.Status == 1)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Nota Fiscal");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Valor Total: {n.ValorTotal}");

                            Console.WriteLine($"Nome do Produto: {n.NomeProduto}");

                            if (Convert.ToInt32(n.TipoImposto) == 0)
                            {
                                Console.WriteLine($"Tipo de Imposto: ICMS");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 1)
                            {
                                Console.WriteLine($"Tipo de Imposto: IPI");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 2)
                            {
                                Console.WriteLine($"Tipo de Imposto: IOF");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 3)
                            {
                                Console.WriteLine($"Tipo de Imposto: Outros");
                            }
                            Console.WriteLine($"Valor Total do Imposto: {n.ValorTotalImposto} \n \n");

                        }

                    }
                    foreach (var n in Lists.Licencas)
                    {
                        if (n.Status == 1)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Licença de Funcionamento.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");

                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }

                            Console.WriteLine($"Endereço do Estabelecimento: {n.Endereco}");

                            if (Convert.ToInt32(n.AreaAtuacao) == 0)
                            {
                                Console.WriteLine($"Área de Atuação: : Industrial");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 1)
                            {
                                Console.WriteLine($"Área de Atuação: : Agropecuario");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 2)
                            {
                                Console.WriteLine($"Área de Atuação: : Metalurgico");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 3)
                            {
                                Console.WriteLine($"Área de Atuação: : Tecnologia");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 4)
                            {
                                Console.WriteLine($"Área de Atuação: : Outro");
                            }
                            Console.WriteLine($"\n");

                        }
                    }

                    foreach (var n in Lists.Contrato)
                    {
                        if (n.Status == 1)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Contrato.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Finalidade: {n.Finalidade}");
                            Console.WriteLine($"Testemunhas: {n.Testemunhas}");
                            Console.WriteLine($"Testemunhas: {n.DataExpiracao} \n \n");
                        }

                    }
                }

                else if (listarStatus == 2)
                {
                    Console.WriteLine($"----------------- Suspenso ------------------------");
                    foreach (var n in Lists.NotaFiscal)
                    {
                        if (n.Status == 2)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Nota Fiscal");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Valor Total: {n.ValorTotal}");

                            Console.WriteLine($"Nome do Produto: {n.NomeProduto}");

                            if (Convert.ToInt32(n.TipoImposto) == 0)
                            {
                                Console.WriteLine($"Tipo de Imposto: ICMS");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 1)
                            {
                                Console.WriteLine($"Tipo de Imposto: IPI");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 2)
                            {
                                Console.WriteLine($"Tipo de Imposto: IOF");
                            }
                            if (Convert.ToInt32(n.TipoImposto) == 3)
                            {
                                Console.WriteLine($"Tipo de Imposto: Outros");
                            }
                            Console.WriteLine($"Valor Total do Imposto: {n.ValorTotalImposto} \n \n");

                        }

                    }

                    foreach (var n in Lists.Licencas)
                    {
                        if (n.Status == 2)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Licença de Funcionamento.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");

                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }

                            Console.WriteLine($"Endereço do Estabelecimento: {n.Endereco}");

                            if (Convert.ToInt32(n.AreaAtuacao) == 0)
                            {
                                Console.WriteLine($"Área de Atuação: : Industrial");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 1)
                            {
                                Console.WriteLine($"Área de Atuação: : Agropecuario");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 2)
                            {
                                Console.WriteLine($"Área de Atuação: : Metalurgico");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 3)
                            {
                                Console.WriteLine($"Área de Atuação: : Tecnologia");
                            }
                            if (Convert.ToInt32(n.AreaAtuacao) == 4)
                            {
                                Console.WriteLine($"Área de Atuação: : Outro");
                            }

                        }
                    }

                    foreach (var n in Lists.Contrato)
                    {
                        if (n.Status == 2)
                        {
                            Console.WriteLine($"Documento Cadastrado do Tipo: Contrato.");
                            Console.WriteLine($"Código do Documento: {n.CodigoDocumento}");
                            Console.WriteLine($"Data de Cadastro: {n.DataCadastroSistema}");
                            Console.WriteLine($"Data da Ultima Alteração: {n.DataUltimaAlteracao}");
                            Console.WriteLine($"Nome do Estabelecimento: {n.NomeEstabelecimento}");
                            Console.WriteLine($"CNPJ: {n.CNPJ}");
                            if (Convert.ToInt32(n.Status) == 0)
                            {
                                Console.WriteLine($"Status: Ativo");
                            }
                            if (Convert.ToInt32(n.Status) == 1)
                            {
                                Console.WriteLine($"Status: Em tramitação");
                            }
                            if (Convert.ToInt32(n.Status) == 2)
                            {
                                Console.WriteLine($"Status: Suspenso");
                            }
                            Console.WriteLine($"Finalidade: {n.Finalidade}");
                            Console.WriteLine($"Testemunhas: {n.Testemunhas}");
                            Console.WriteLine($"Testemunhas: {n.DataExpiracao} \n \n");
                        }

                    }
                }




                Console.WriteLine("Pressione Enter para voltar ao menu...");
                Console.ReadKey();


            }

            break;





    }
}

