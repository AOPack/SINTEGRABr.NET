# SINTEGRABr
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SINTEGRA.

###TODO

- [ ] Melhorar geração do Registro Tipo 90 para comportar mais de 1 registro deste tipo no arquivo.

##Ajuda?

Visite a Wiki do projeto ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/wiki).

##Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui] (https://github.com/samuelroliveira/SINTEGRABr/issues).

##Exemplos

```cs
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
```
