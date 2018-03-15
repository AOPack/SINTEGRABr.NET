# SINTEGRABr
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2017 - para geração dos arquivos SINTEGRA.

## Doações [![Donate](https://img.shields.io/badge/Doações-Doare-ff69b4.svg)](http://doa.re/1bz00)

Se o projeto lhe ajudou ou contribuiu de alguma forma, faça uma doação. :D Ajude a dar continuidade nesse projeto.

###TODO

- [x] Melhorar geração do Registro Tipo 90 para comportar mais de 1 registro deste tipo no arquivo.

##Ajuda?

Visite a Wiki do projeto ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/wiki).

##Colaboradores

AutoCom - Microplan Automação Comercial Ltda - MG
- Eduardo Moreira
- Bruno Novaes - (33) 3331-5808
- Whashington Reis

##Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/issues).

##Exemplos

```cs

/* REGISTROS ÚNICOS NO ARQUIVO */

var r10 = new Registro10(
Cnpj: "01234567000899",
Ie: "1012345678",
RazaoSocial: "EMPRESA DE TESTE",
Municipio: "CIDADE DE DEUS",
Uf: "GO",
Fax: "123456789",
DataInicial: DateTime.Now.ObterPrimeiroDiaMesAtual(),
DataFinal: DateTime.Now.ObterUltimoDiaMesAtual(),
CodFin: CodFinalidadeArquivo.Cod1
);

var result = r10.EscreverCampos();

//---------------------------------

var r11 = new Registro11(
Logradouro: "RUA SEM NOME PARA TESTE",
Numero: "",
Complemento: "",
Bairro: "CENTRO",
Cep: "36900000",
NomeContato: "ADEMERIO EDUARDO MOREIRA",
NumeroContato: "3333315808"
);

var result = r11.EscreverCampos();

/* REGISTROS DE OCORRÊNCIA MÚLTIPLA NO ARQUIVO */

var r50 = new Registro50();

// Exemplo de nota de compra de material p/ uso ou consumo (copos descartáveis por exemplo)
r50.Cnpj = "01234567000899";
r50.InscrEstadual = "1012345678";
r50.DataEmissaoRecebimento = DateTime.Now;
r50.Uf = "GO";
r50.Modelo = 55;
r50.Serie = "001";
r50.Numero = 123456;
r50.Cfop = 1556;
r50.Emitente = "T";
r50.ValorTotal = 50.55M;
r50.ValorOutras = 50.55M;
r50.SituacaoNotaFiscal = "N";

var result = r50.EscreverCampos();
```
