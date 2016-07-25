# SINTEGRABr
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SINTEGRA.

##Ajuda?

Visite a Wiki do projeto ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/wiki).

##Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/issues).

##Exemplos

```cs
var r10 = new Registro10();

// Inicio das informações do registro
r10.CgcMf = "01234567000899";
r10.InscricaoEstadual = "1012345678";
r10.NomeContribuinte = "EMPRESA DE TESTE";
r10.Municipio = "CIDADE DE DEUS";
r10.Uf = "DF";
r10.Fax = "123456789";
r10.DataInicial = DateTime.Now.ObterPrimeiroDiaMesAtual();
r10.DataFinal = DateTime.Now.ObterUltimoDiaMesAtual();
r10.CodEstrutura = 3;
r10.CodOperacoes = 3;
r10.CodFinalidade = 1;
// Fim das informações do registro

// Chamada do método que efetua a geração da(s) linha(s)
var result = r10.EscreverCampos();
```
