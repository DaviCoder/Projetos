using RDB_API.Models;
using RDB_API.Models.ClienteModels;
using RDB_API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDB_API.Services
{
    public class SeendingService
    {
        private readonly Context _context;

        public SeendingService(Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Clientes.Any())
            {
                return;
            }
            else
            {
                List<Cliente> Clientes = new List<Cliente>
                {
                    new Cliente{
                        Nome = "Cyrus Donaldson",
                        Documento = "64624918663"
                    },
                    new Cliente{
                        Nome = "Athena Hamilton",
                        Documento = "45687390378"
                    },
                    new Cliente{
                        Nome = "Jenette Callahan",
                        Documento = "19403453760"
                    },
                    new Cliente{
                        Nome = "Madeson Snyder",
                        Documento = "21234926416"
                    },
                    new Cliente{
                        Nome = "Anjolie Clemons",
                        Documento = "85197482667"
                    },
                    new Cliente{
                        Nome = "Abdul Barry",
                        Documento = "58620675331"
                    },
                    new Cliente{
                        Nome = "Keegan Schmidt",
                        Documento = "71428917634"
                    },
                    new Cliente{
                        Nome = "Hanna Mack",
                        Documento = "38470502460"
                    },
                    new Cliente{
                        Nome = "Leroy Bradshaw",
                        Documento = "46301700801"
                    },
                    new Cliente{
                        Nome = "Orson Medina",
                        Documento = "15414768027"
                    },
                    new Cliente{
                        Nome = "Fleur Lara",
                        Documento = "25323617402"
                    },
                    new Cliente{
                        Nome = "Sonia Montoya",
                        Documento = "82187234434"
                    },
                    new Cliente{
                        Nome = "Vernon Clarke",
                        Documento = "38282165835"
                    },
                    new Cliente{
                        Nome = "Rowan Buck",
                        Documento = "83234184674"
                    },
                    new Cliente{
                        Nome = "Zelda Clark",
                        Documento = "20668571385"
                    },
                    new Cliente{
                        Nome = "Ingrid Young",
                        Documento = "05160222765"
                    },
                    new Cliente{
                        Nome = "Karly Conley",
                        Documento = "45726598283"
                    },
                    new Cliente{
                        Nome = "Keelie Stewart",
                        Documento = "81818133326"
                    },
                    new Cliente{
                        Nome = "Darrel Rich",
                        Documento = "72909408656"
                    },
                    new Cliente{
                        Nome = "Chandler Walton",
                        Documento = "43021926659"
                    },
                    new Cliente{
                        Nome = "Ebony Knox",
                        Documento = "25965373698"
                    },
                    new Cliente{
                        Nome = "Lane Long",
                        Documento = "56810313105"
                    },
                    new Cliente{
                        Nome = "Brent Hatfield",
                        Documento = "84661263238"
                    },
                    new Cliente{
                        Nome = "Isabella Martin",
                        Documento = "03817761414"
                    },
                    new Cliente{
                        Nome = "Wade Durham",
                        Documento = "69933574735"
                    },
                    new Cliente{
                        Nome = "Samuel Arnold",
                        Documento = "62740385710"
                    },
                    new Cliente{
                        Nome = "Burton Glover",
                        Documento = "59887928111"
                    },
                    new Cliente{
                        Nome = "Sybil Maddox",
                        Documento = "72626142247"
                    },
                    new Cliente{
                        Nome = "Willa Brown",
                        Documento = "40348067501"
                    },
                    new Cliente{
                        Nome = "Hamish Cash",
                        Documento = "32734241303"
                    },
                    new Cliente{
                        Nome = "Amir Reese",
                        Documento = "31335725446"
                    },
                    new Cliente{
                        Nome = "Stella Christensen",
                        Documento = "58466249474"
                    },
                    new Cliente{
                        Nome = "Sigourney Hall",
                        Documento = "17217857887"
                    },
                    new Cliente{
                        Nome = "Mufutau Daugherty",
                        Documento = "24327510342"
                    },
                    new Cliente{
                        Nome = "Hall Bullock",
                        Documento = "08135836473"
                    },
                    new Cliente{
                        Nome = "Tate Mcfadden",
                        Documento = "63692774212"
                    },
                    new Cliente{
                        Nome = "Mark Peters",
                        Documento = "96452058747"
                    },
                    new Cliente{
                        Nome = "Samuel Rodriguez",
                        Documento = "29278981199"
                    },
                    new Cliente{
                        Nome = "Eve Wiley",
                        Documento = "40692157391"
                    },
                    new Cliente{
                        Nome = "Travis Tanner",
                        Documento = "43148066838"
                    },
                    new Cliente{
                        Nome = "Odessa Garcia",
                        Documento = "75641283560"
                    },
                    new Cliente{
                        Nome = "Joelle Thompson",
                        Documento = "92388516085"
                    },
                    new Cliente{
                        Nome = "Abraham Bryan",
                        Documento = "96860238593"
                    },
                    new Cliente{
                        Nome = "Callum Robertson",
                        Documento = "42096682071"
                    },
                    new Cliente{
                        Nome = "Lisandra Guerrero",
                        Documento = "56601378842"
                    },
                    new Cliente{
                        Nome = "Howard Barton",
                        Documento = "48741288481"
                    },
                    new Cliente{
                        Nome = "Grant Guerra",
                        Documento = "65848565833"
                    },
                    new Cliente{
                        Nome = "Patience Love",
                        Documento = "86338611856"
                    },
                    new Cliente{
                        Nome = "Orlando Bradshaw",
                        Documento = "38607053605"
                    },
                    new Cliente{
                        Nome = "Byron Sears",
                        Documento = "02380406104"
                    },
                    new Cliente{
                        Nome = "Elijah Roth",
                        Documento = "943384118478146"
                    },
                    new Cliente{
                        Nome = "Jordan Wright",
                        Documento = "212415128388834"
                    },
                    new Cliente{
                        Nome = "Judith Chavez",
                        Documento = "382666628680431"
                    },
                    new Cliente{
                        Nome = "Ruth Salas",
                        Documento = "525732893478227"
                    },
                    new Cliente{
                        Nome = "Ashton Mckay",
                        Documento = "932870812404723"
                    },
                    new Cliente{
                        Nome = "Noelle Phillips",
                        Documento = "314804675811827"
                    },
                    new Cliente{
                        Nome = "Amela Duncan",
                        Documento = "316640315133228"
                    },
                    new Cliente{
                        Nome = "August Briggs",
                        Documento = "440212246220552"
                    },
                    new Cliente{
                        Nome = "Cain Knowles",
                        Documento = "661683147551355"
                    },
                    new Cliente{
                        Nome = "Ali Briggs",
                        Documento = "384315318287720"
                    },
                    new Cliente{
                        Nome = "Cade Cooper",
                        Documento = "780480847568367"
                    },
                    new Cliente{
                        Nome = "Denise Gonzalez",
                        Documento = "810163767629758"
                    },
                    new Cliente{
                        Nome = "Hyacinth Haynes",
                        Documento = "377822224122514"
                    },
                    new Cliente{
                        Nome = "Rae Thornton",
                        Documento = "322154472191908"
                    },
                    new Cliente{
                        Nome = "Eric Stafford",
                        Documento = "805825525229205"
                    },
                    new Cliente{
                        Nome = "Chester Travis",
                        Documento = "066877517238238"
                    },
                    new Cliente{
                        Nome = "Faith Wiggins",
                        Documento = "775579111021392"
                    },
                    new Cliente{
                        Nome = "Alexa Powers",
                        Documento = "313678035469406"
                    },
                    new Cliente{
                        Nome = "Rosalyn Summers",
                        Documento = "716211421516285"
                    },
                    new Cliente{
                        Nome = "Raymond Hood",
                        Documento = "870179751134781"
                    },
                    new Cliente{
                        Nome = "Beatrice Harmon",
                        Documento = "261954372897048"
                    },
                    new Cliente{
                        Nome = "Mark Simpson",
                        Documento = "679586178454431"
                    },
                    new Cliente{
                        Nome = "Wang Bauer",
                        Documento = "625677596546354"
                    },
                    new Cliente{
                        Nome = "Carly Mullen",
                        Documento = "132456378595632"
                    },
                    new Cliente{
                        Nome = "Kessie Tillman",
                        Documento = "831213338548731"
                    },
                    new Cliente{
                        Nome = "Richard Anderson",
                        Documento = "715716917212901"
                    },
                    new Cliente{
                        Nome = "Kimberley Conner",
                        Documento = "684258472774647"
                    },
                    new Cliente{
                        Nome = "Silas Floyd",
                        Documento = "277631116319017"
                    },
                    new Cliente{
                        Nome = "Yetta Humphrey",
                        Documento = "297931226129995"
                    },
                    new Cliente{
                        Nome = "Priscilla Burch",
                        Documento = "184962181742723"
                    },
                    new Cliente{
                        Nome = "Philip Beasley",
                        Documento = "879113946426327"
                    },
                    new Cliente{
                        Nome = "Nathan Rodgers",
                        Documento = "798522027477530"
                    },
                    new Cliente{
                        Nome = "Zorita Parks",
                        Documento = "839764943071727"
                    },
                    new Cliente{
                        Nome = "Garrett Williamson",
                        Documento = "542326464956175"
                    },
                    new Cliente{
                        Nome = "Jenna Atkins",
                        Documento = "489046436786039"
                    },
                    new Cliente{
                        Nome = "Anne Garcia",
                        Documento = "578558159647075"
                    },
                    new Cliente{
                        Nome = "Addison Barnett",
                        Documento = "466717391037898"
                    },
                    new Cliente{
                        Nome = "Cody Kennedy",
                        Documento = "927885102633567"
                    },
                    new Cliente{
                        Nome = "Derek Hayden",
                        Documento = "745420816110467"
                    },
                    new Cliente{
                        Nome = "Faith Floyd",
                        Documento = "194583878304842"
                    },
                    new Cliente{
                        Nome = "Chaim Stanton",
                        Documento = "892114102542947"
                    },
                    new Cliente{
                        Nome = "Roth Cervantes",
                        Documento = "314802557687622"
                    },
                    new Cliente{
                        Nome = "Rina Jimenez",
                        Documento = "783525712838542"
                    },
                    new Cliente{
                        Nome = "Hop Berger",
                        Documento = "546632485109276"
                    },
                    new Cliente{
                        Nome = "Georgia Barron",
                        Documento = "657657054302869"
                    },
                    new Cliente{
                        Nome = "Amanda Rosales",
                        Documento = "886479926138505"
                    },
                    new Cliente{
                        Nome = "Tate Glass",
                        Documento = "954387267234857"
                    },
                    new Cliente{
                        Nome = "Pearl Mathews",
                        Documento = "377224324554148"
                    },
                    new Cliente{
                        Nome = "Mallory Sawyer",
                        Documento = "927170734073135"
                    },
                    new Cliente{
                        Nome = "Genevieve Ross",
                        Documento = "980877659737528"
                    }
                };

                List<Endereco> Enderecos = new List<Endereco>
                {
					new Endereco{
						Cep = "45617-918",
						Rua = "3850 Non Av.",
						Bairro = "Maranhão",
						Numero = 340,
						Tipo = EnderecoTipo.Entrega,
						Municipio = "Criciúma",
						ClienteId = 1
					},
					new Endereco{
						Cep = "88611-592",
						Rua = "2708 A, Ave",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 561,
						Municipio = "Lauro de Freitas",
						ClienteId = 2
					},
					new Endereco{
						Cep = "60821-670",
						Rua = "Ap #427-6706 Eu St.",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Comercial,
						Numero = 456,
						Municipio = "Cabo de Santo Agostinho",
						ClienteId = 3
					},
					new Endereco{
						Cep = "37024813",
						Rua = "739-729 Sem St.",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 956,
						Municipio = "Montes Claros",
						ClienteId = 4
					},
					new Endereco{
						Cep = "53074-825",
						Rua = "551-1685 Risus St.",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 324,
						Municipio = "Itajaí",
						ClienteId = 5
					},
					new Endereco{
						Cep = "66131-471",
						Rua = "Ap #685-1514 Pellentesque Avenue",
						Bairro = "Pernambuco",
						Tipo = EnderecoTipo.Comercial,
						Numero = 420,
						Municipio = "Juazeiro do Norte",
						ClienteId = 6
					},
					new Endereco{
						Cep = "67843-111",
						Rua = "P.O. Box 238, 1357 Luctus Av.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 777,
						Municipio = "Paranaguá",
						ClienteId = 7
					},
					new Endereco{
						Cep = "65166-711",
						Rua = "Ap #503-6628 Suspendisse St.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Entrega,
						Numero = 754,
						Municipio = "Camaçari",
						ClienteId = 8
					},
					new Endereco{
						Cep = "93441-030",
						Rua = "Ap #840-6392 Taciti St.",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 659,
						Municipio = "Águas Lindas de Goiás",
						ClienteId = 9
					},
					new Endereco{
						Cep = "93671-172",
						Rua = "Ap #104-4239 Elit. St.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Comercial,
						Numero = 141,
						Municipio = "Abaetetuba",
						ClienteId = 10
					},
					new Endereco{
						Cep = "58253-158",
						Rua = "Ap #905-1831 Duis St.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 743,
						Municipio = "Petrolina",
						ClienteId = 11
					},
					new Endereco{
						Cep = "68354-445",
						Rua = "Ap #473-2802 Velit. Street",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Entrega,
						Numero = 344,
						Municipio = "Caucaia",
						ClienteId = 12
					},
					new Endereco{
						Cep = "48270-119",
						Rua = "2213 Lobortis St.",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 856,
						Municipio = "Vitória da Conquista",
						ClienteId = 13
					},
					new Endereco{
						Cep = "88341-683",
						Rua = "541-6599 Tellus Street",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Comercial,
						Numero = 839,
						Municipio = "Rio Verde",
						ClienteId = 14
					},
					new Endereco{
						Cep = "88656-503",
						Rua = "Ap #879-979 Integer Av.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Residencial,
						Numero = 216,
						Municipio = "Fortaleza",
						ClienteId = 15
					},
					new Endereco{
						Cep = "76751-853",
						Rua = "P.O. Box 924, 8383 Et, St.",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Entrega,
						Numero = 878,
						Municipio = "Carapicuíba",
						ClienteId = 16
					},
					new Endereco{
						Cep = "75789-782",
						Rua = "Ap #863-559 Amet Ave",
						Bairro = "Paraíba",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 787,
						Municipio = "Campos dos Goytacazes",
						ClienteId = 17
					},
					new Endereco{
						Cep = "42955-257",
						Rua = "Ap #195-4862 Ligula. St.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Comercial,
						Numero = 512,
						Municipio = "Jundiaí",
						ClienteId = 18
					},
					new Endereco{
						Cep = "61171-362",
						Rua = "P.O. Box 439, 9004 Pede. Road",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Entrega,
						Numero = 583,
						Municipio = "Caxias do Sul",
						ClienteId = 19
					},
					new Endereco{
						Cep = "58556-879",
						Rua = "667-8463 Luctus Road",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 393,
						Municipio = "Sousa",
						ClienteId = 20
					},
					new Endereco{
						Cep = "84877-046",
						Rua = "614-6372 Vel Rd.",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Comercial,
						Numero = 428,
						Municipio = "Caxias do Sul",
						ClienteId = 21
					},
					new Endereco{
						Cep = "95332-225",
						Rua = "173-6080 Integer Rd.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Entrega,
						Numero = 070,
						Municipio = "Maracanaú",
						ClienteId = 22
					},
					new Endereco{
						Cep = "13349-082",
						Rua = "772-291 In, Rd.",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 765,
						Municipio = "Marabá",
						ClienteId = 23
					},
					new Endereco{
						Cep = "76758-846",
						Rua = "P.O. Box 949, 7714 Tempus, Ave",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Comercial,
						Numero = 606,
						Municipio = "Valparaíso de Goiás",
						ClienteId = 24
					},
					new Endereco{
						Cep = "88888-636",
						Rua = "Ap #473-7910 Metus Street",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 933,
						Municipio = "Foz do Iguaçu",
						ClienteId = 25
					},
					new Endereco{
						Cep = "88530-777",
						Rua = "698-687 Lobortis Rd.",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Residencial,
						Numero = 126,
						Municipio = "Ribeirão Preto",
						ClienteId = 26
					},
					new Endereco{
						Cep = "16123-210",
						Rua = "Ap #502-5539 Ullamcorper Road",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Residencial,
						Numero = 164,
						Municipio = "Mauá",
						ClienteId = 27
					},
					new Endereco{
						Cep = "75755-855",
						Rua = "Ap #669-8085 Mus. Rd.",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Entrega,
						Numero = 742,
						Municipio = "Juazeiro",
						ClienteId = 28
					},
					new Endereco{
						Cep = "58303-240",
						Rua = "P.O. Box 619, 5039 Habitant Av.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 226,
						Municipio = "Chapadinha",
						ClienteId = 29
					},
					new Endereco{
						Cep = "75774-742",
						Rua = "Ap #359-3981 Non Road",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Comercial,
						Numero = 622,
						Municipio = "Itajaí",
						ClienteId = 30
					},
					new Endereco{
						Cep = "15168-868",
						Rua = "P.O. Box 663, 3878 In Road",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 675,
						Municipio = "Contagem",
						ClienteId = 31
					},
					new Endereco{
						Cep = "95066-372",
						Rua = "Ap #262-8279 Risus. Av.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 624,
						Municipio = "Santarém",
						ClienteId = 32
					},
					new Endereco{
						Cep = "43778-357",
						Rua = "P.O. Box 178, 7563 Elit, Rd.",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Comercial,
						Numero = 305,
						Municipio = "Marabá",
						ClienteId = 33
					},
					new Endereco{
						Cep = "68258-489",
						Rua = "605-9969 Consequat St.",
						Bairro = "Paraíba",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 815,
						Municipio = "Vitória da Conquista",
						ClienteId = 34
					},
					new Endereco{
						Cep = "82374-195",
						Rua = "188 Consectetuer Avenue",
						Bairro = "Pará",
						Numero = 582,
						Municipio = "Campina Grande",
						ClienteId = 35
					},
					new Endereco{
						Cep = "52836-315",
						Rua = "5261 Donec Avenue",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 486,
						Municipio = "Belford Roxo",
						ClienteId = 36
					},
					new Endereco{
						Cep = "58384-682",
						Rua = "Ap #113-9903 Neque Avenue",
						Bairro = "Rio de Janeiro",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 346,
						Municipio = "Luziânia",
						ClienteId = 37
					},
					new Endereco{
						Cep = "34617612",
						Rua = "Ap #956-3771 Ut Av.",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Comercial,
						Numero = 165,
						Municipio = "Balsas",
						ClienteId = 38
					},
					new Endereco{
						Cep = "91287-819",
						Rua = "766-8873 Sit Road",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 150,
						Municipio = "Divinópolis",
						ClienteId = 39
					},
					new Endereco{
						Cep = "65249-738",
						Rua = "6263 Integer Street",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Entrega,
						Numero = 803,
						Municipio = "Sete Lagoas",
						ClienteId = 40
					},
					new Endereco{
						Cep = "35066414",
						Rua = "P.O. Box 425, 9716 Sed, Rd.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 121,
						Municipio = "Juazeiro do Norte",
						ClienteId = 41
					},
					new Endereco{
						Cep = "65527-760",
						Rua = "P.O. Box 308, 9499 Mollis St.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Comercial,
						Numero = 174,
						Municipio = "Lauro de Freitas",
						ClienteId = 42
					},
					new Endereco{
						Cep = "87467-923",
						Rua = "Ap #301-6576 Duis Rd.",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 385,
						Municipio = "Aparecida de Goiânia",
						ClienteId = 43
					},
					new Endereco{
						Cep = "97437-682",
						Rua = "P.O. Box 148, 6878 Ipsum. Avenue",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Residencial,
						Numero = 167,
						Municipio = "Olinda",
						ClienteId = 44
					},
					new Endereco{
						Cep = "27375-585",
						Rua = "8252 Nunc Ave",
						Bairro = "Rio de Janeiro",
						Tipo = EnderecoTipo.Entrega,
						Numero = 131,
						Municipio = "Juazeiro do Norte",
						ClienteId = 45
					},
					new Endereco{
						Cep = "48482-816",
						Rua = "4788 Arcu. Rd.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 403,
						Municipio = "Petrópolis",
						ClienteId = 46
					},
					new Endereco{
						Cep = "16812-868",
						Rua = "297-8105 Malesuada Av.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Comercial,
						Numero = 181,
						Municipio = "Anápolis",
						ClienteId = 47
					},
					new Endereco{
						Cep = "63667-367",
						Rua = "902-7911 Magna. Avenue",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 111,
						Municipio = "Recife",
						ClienteId = 48
					},
					new Endereco{
						Cep = "35217779",
						Rua = "415-9124 Laoreet Rd.",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 786,
						Municipio = "Jundiaí",
						ClienteId = 49
					},
					new Endereco{
						Cep = "58970-469",
						Rua = "892-5535 Aliquam Ave",
						Bairro = "Pernambuco",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 492,
						Municipio = "Maringá",
						ClienteId = 50
					},
					new Endereco{
						Cep = "63824-163",
						Rua = "578-843 Posuere Rd.",
						Bairro = "Pernambuco",
						Tipo = EnderecoTipo.Comercial,
						Numero = 327,
						Municipio = "Itapipoca",
						ClienteId = 51
					},
					new Endereco{
						Cep = "62778-152",
						Rua = "P.O. Box 768, 618 Dolor, Rd.",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 825,
						Municipio = "Florianópolis",
						ClienteId = 52
					},
					new Endereco{
						Cep = "60667-335",
						Rua = "259-7781 Ipsum St.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Entrega,
						Numero = 743,
						Municipio = "Londrina",
						ClienteId = 53
					},
					new Endereco{
						Cep = "62428-889",
						Rua = "Ap #958-2731 Dapibus Avenue",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 472,
						Municipio = "Londrina",
						ClienteId = 54
					},
					new Endereco{
						Cep = "54032-963",
						Rua = "412-471 Dictum St.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Comercial,
						Numero = 347,
						Municipio = "Ilhéus",
						ClienteId = 55
					},
					new Endereco{
						Cep = "18853-629",
						Rua = "649-706 Donec Av.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 618,
						Municipio = "Marabá",
						ClienteId = 56
					},
					new Endereco{
						Cep = "75768-100",
						Rua = "Ap #732-1279 Et Rd.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Entrega,
						Numero = 764,
						Municipio = "Joinville",
						ClienteId = 57
					},
					new Endereco{
						Cep = "65676-316",
						Rua = "175-6679 Enim Avenue",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 988,
						Municipio = "Codó",
						ClienteId = 58
					},
					new Endereco{
						Cep = "74765-605",
						Rua = "226-993 Mollis Rd.",
						Bairro = "Bahia",
						Tipo = EnderecoTipo.Comercial,
						Numero = 113,
						Municipio = "Chapecó",
						ClienteId = 59
					},
					new Endereco{
						Cep = "11338-483",
						Rua = "P.O. Box 665, 7041 Dignissim St.",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 729,
						Municipio = "Petrópolis",
						ClienteId = 60
					},
					new Endereco{
						Cep = "84565-119",
						Rua = "5019 Magna. Road",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 522,
						Municipio = "Porto Alegre",
						ClienteId = 61
					},
					new Endereco{
						Cep = "81518-318",
						Rua = "P.O. Box 683, 6499 Libero. Street",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Entrega,
						Numero = 594,
						Municipio = "Ponta Grossa",
						ClienteId = 62
					},
					new Endereco{
						Cep = "65624-871",
						Rua = "P.O. Box 245, 4148 Sit St.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 872,
						Municipio = "Contagem",
						ClienteId = 63
					},
					new Endereco{
						Cep = "60841-144",
						Rua = "251-4256 Montes, Road",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Comercial,
						Numero = 672,
						Municipio = "Ponta Grossa",
						ClienteId = 64
					},
					new Endereco{
						Cep = "58248-663",
						Rua = "5147 Nulla Ave",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 423,
						Municipio = "Ananindeua",
						ClienteId = 65
					},
					new Endereco{
						Cep = "42654-588",
						Rua = "P.O. Box 216, 6948 Vel St.",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 853,
						Municipio = "Rio Verde",
						ClienteId = 66
					},
					new Endereco{
						Cep = "24204-269",
						Rua = "P.O. Box 944, 4176 Erat Road",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 356,
						Municipio = "Jaboatão dos Guararapes",
						ClienteId = 67
					},
					new Endereco{
						Cep = "67463-122",
						Rua = "7776 Erat Street",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Comercial,
						Numero = 335,
						Municipio = "Timon",
						ClienteId = 68
					},
					new Endereco{
						Cep = "97111-654",
						Rua = "P.O. Box 172, 5445 Facilisis Avenue",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Entrega,
						Numero = 837,
						Municipio = "São José",
						ClienteId = 69
					},
					new Endereco{
						Cep = "35174464",
						Rua = "Ap #410-1490 Integer Av.",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 321,
						Municipio = "Canoas",
						ClienteId = 70
					},
					new Endereco{
						Cep = "40187-317",
						Rua = "P.O. Box 116, 8026 Tortor. St.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 202,
						Municipio = "Florianópolis",
						ClienteId = 71
					},
					new Endereco{
						Cep = "23355-792",
						Rua = "Ap #848-6824 Ante St.",
						Bairro = "Minas Gerais",
						Tipo = EnderecoTipo.Entrega,
						Numero = 763,
						Municipio = "Porto Alegre",
						ClienteId = 72
					},
					new Endereco{
						Cep = "76774-813",
						Rua = "998-2578 Posuere Street",
						Bairro = "Rio de Janeiro",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 501,
						Municipio = "Olinda",
						ClienteId = 73
					},
					new Endereco{
						Cep = "62234-765",
						Rua = "5749 Neque Street",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Comercial,
						Numero = 183,
						Municipio = "Belém",
						ClienteId = 74
					},
					new Endereco{
						Cep = "52748-693",
						Rua = "102-7875 Vitae St.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 685,
						Municipio = "São João de Meriti",
						ClienteId = 75
					},
					new Endereco{
						Cep = "81574-245",
						Rua = "Ap #889-5132 Amet, Rd.",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Residencial,
						Numero = 588,
						Municipio = "Ribeirão Preto",
						ClienteId = 76
					},
					new Endereco{
						Cep = "90897-163",
						Rua = "465 Vehicula. St.",
						Bairro = "Pará",
						Numero = 923,
						Municipio = "Balsas",
						ClienteId = 77
					},
					new Endereco{
						Cep = "47707-765",
						Rua = "Ap #201-717 Nulla Avenue",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Residencial,
						Numero = 743,
						Municipio = "São João de Meriti",
						ClienteId = 78
					},
					new Endereco{
						Cep = "52315-177",
						Rua = "Ap #786-8293 Pellentesque Street",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Entrega,
						Numero = 641,
						Municipio = "Joinville",
						ClienteId = 79
					},
					new Endereco{
						Cep = "58574-752",
						Rua = "881-5292 Sed Street",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 848,
						Municipio = "Marabá",
						ClienteId = 80
					},
					new Endereco{
						Cep = "43083-360",
						Rua = "Ap #774-2132 Interdum Street",
						Bairro = "Pará",
						Tipo = EnderecoTipo.Comercial,
						Numero = 878,
						Municipio = "Campina Grande",
						ClienteId = 81
					},
					new Endereco{
						Cep = "65668-631",
						Rua = "Ap #655-2132 Aenean Rd.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 731,
						Municipio = "Mauá",
						ClienteId = 82
					},
					new Endereco{
						Cep = "58763-364",
						Rua = "P.O. Box 442, 8565 Vel Street",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Residencial,
						Numero = 457,
						Municipio = "Aparecida de Goiânia",
						ClienteId = 83
					},
					new Endereco{
						Cep = "58142-155",
						Rua = "P.O. Box 574, 8895 Dolor Rd.",
						Bairro = "Paraíba",
						Tipo = EnderecoTipo.Entrega,
						Numero = 011,
						Municipio = "Bragança",
						ClienteId = 84
					},
					new Endereco{
						Cep = "73763-240",
						Rua = "Ap #140-3125 Porttitor Avenue",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 722,
						Municipio = "Ilhéus",
						ClienteId = 85
					},
					new Endereco{
						Cep = "45713-366",
						Rua = "Ap #263-7929 Nisi. Road",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Comercial,
						Numero = 726,
						Municipio = "Cascavel",
						ClienteId = 86
					},
					new Endereco{
						Cep = "61818-449",
						Rua = "P.O. Box 821, 3285 Dui. St.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 832,
						Municipio = "Petrópolis",
						ClienteId = 87
					},
					new Endereco{
						Cep = "66056-774",
						Rua = "Ap #420-8887 Luctus Street",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Entrega,
						Numero = 317,
						Municipio = "Goiânia",
						ClienteId = 88
					},
					new Endereco{
						Cep = "74758-361",
						Rua = "145-6179 Erat, Rd.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 556,
						Municipio = "Blumenau",
						ClienteId = 89
					},
					new Endereco{
						Cep = "35505460",
						Rua = "Ap #921-5342 Malesuada St.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Comercial,
						Numero = 416,
						Municipio = "Santa Luzia",
						ClienteId = 90
					},
					new Endereco{
						Cep = "88626-536",
						Rua = "P.O. Box 491, 708 Scelerisque Av.",
						Bairro = "Rio de Janeiro",
						Tipo = EnderecoTipo.Entrega,
						Numero = 629,
						Municipio = "Rio de Janeiro",
						ClienteId = 91
					},
					new Endereco{
						Cep = "67391-179",
						Rua = "P.O. Box 170, 3369 Rutrum, Avenue",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 435,
						Municipio = "Valparaíso de Goiás",
						ClienteId = 92
					},
					new Endereco{
						Cep = "93051-134",
						Rua = "Ap #439-6842 Netus Av.",
						Bairro = "Goiás",
						Tipo = EnderecoTipo.Comercial,
						Numero = 386,
						Municipio = "Cajazeiras",
						ClienteId = 93
					},
					new Endereco{
						Cep = "65335-485",
						Rua = "Ap #682-3281 Pede St.",
						Bairro = "Maranhão",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 682,
						Municipio = "Duque de Caxias",
						ClienteId = 94
					},
					new Endereco{
						Cep = "14251-753",
						Rua = "205-1987 Ipsum St.",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Residencial,
						Numero = 134,
						Municipio = "Ribeirão Preto",
						ClienteId = 95
					},
					new Endereco{
						Cep = "88685-960",
						Rua = "7510 Nonummy Rd.",
						Bairro = "Rio Grande do Sul",
						Tipo = EnderecoTipo.Entrega,
						Numero = 529,
						Municipio = "João Pessoa",
						ClienteId = 96
					},
					new Endereco{
						Cep = "96437-112",
						Rua = "560-3589 Orci. Rd.",
						Bairro = "Santa Catarina",
						Tipo = EnderecoTipo.Cobrança,
						Numero = 547,
						Municipio = "Rio Verde",
						ClienteId = 97
					},
					new Endereco{
						Cep = "58674-878",
						Rua = "955 In Road",
						Bairro = "São Paulo",
						Tipo = EnderecoTipo.Comercial,
						Numero = 071,
						Municipio = "Foz do Iguaçu",
						ClienteId = 98
					},
					new Endereco{
						Cep = "45743-518",
						Rua = "P.O. Box 369, 4304 Ut St.",
						Bairro = "Paraná",
						Tipo = EnderecoTipo.Correspondencia,
						Numero = 789,
						Municipio = "Goiânia",
						ClienteId = 99
					},
					new Endereco{
						Cep = "88832-972",
						Rua = "Ap #997-1654 Adipiscing Ave",
						Bairro = "Ceará",
						Tipo = EnderecoTipo.Entrega,
						Numero = 779,
						Municipio = "Criciúma",
						ClienteId = 100
					}
				};

				List<Telefone> telefones = new List<Telefone>
				{
					new Telefone{
						Numero = "66441688953",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 1
					},
					new Telefone{
						Numero = "75622064857",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 2
					},
					new Telefone{
						Numero = "39718527246",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 3
					},
					new Telefone{
						Numero = "12318573426",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 4
					},
					new Telefone{
						Numero = "94665831552",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 5
					},
					new Telefone{
						Numero = "40395425742",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 6
					},
					new Telefone{
						Numero = "17513666710",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 7
					},
					new Telefone{
						Numero = "73852328084",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 8
					},
					new Telefone{
						Numero = "64955647538",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 9
					},
					new Telefone{
						Numero = "86655752782",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 10
					},
					new Telefone{
						Numero = "88226238313",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 11
					},
					new Telefone{
						Numero = "66402435801",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 12
					},
					new Telefone{
						Numero = "77645376475",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 13
					},
					new Telefone{
						Numero = "86210895493",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 14
					},
					new Telefone{
						Numero = "84840804744",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 15
					},
					new Telefone{
						Numero = "19462887247",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 16
					},
					new Telefone{
						Numero = "67763629234",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 17
					},
					new Telefone{
						Numero = "73951263621",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 18
					},
					new Telefone{
						Numero = "85322196871",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 19
					},
					new Telefone{
						Numero = "32144503037",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 20
					},
					new Telefone{
						Numero = "83496437377",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 21
					},
					new Telefone{
						Numero = "46663851221",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 22
					},
					new Telefone{
						Numero = "43103657501",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 23
					},
					new Telefone{
						Numero = "13286884648",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 24
					},
					new Telefone{
						Numero = "57857585557",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 25
					},
					new Telefone{
						Numero = "19495766398",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 26
					},
					new Telefone{
						Numero = "33387892551",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 27
					},
					new Telefone{
						Numero = "16284426183",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 28
					},
					new Telefone{
						Numero = "98868312519",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 29
					},
					new Telefone{
						Numero = "84268450753",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 30
					},
					new Telefone{
						Numero = "70178554877",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 31
					},
					new Telefone{
						Numero = "55766813842",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 32
					},
					new Telefone{
						Numero = "37752513753",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 33
					},
					new Telefone{
						Numero = "43414792563",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 34
					},
					new Telefone{
						Numero = "11836559024",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 35
					},
					new Telefone{
						Numero = "38075847255",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 36
					},
					new Telefone{
						Numero = "89228488515",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 37
					},
					new Telefone{
						Numero = "69889157827",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 38
					},
					new Telefone{
						Numero = "73654915593",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 39
					},
					new Telefone{
						Numero = "12568129549",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 40
					},
					new Telefone{
						Numero = "73239179438",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 41
					},
					new Telefone{
						Numero = "25836239262",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 42
					},
					new Telefone{
						Numero = "24069841806",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 43
					},
					new Telefone{
						Numero = "00246713526",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 44
					},
					new Telefone{
						Numero = "63766481125",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 45
					},
					new Telefone{
						Numero = "72995869767",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 46
					},
					new Telefone{
						Numero = "89855610237",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 47
					},
					new Telefone{
						Numero = "84548634170",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 48
					},
					new Telefone{
						Numero = "84257575566",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 49
					},
					new Telefone{
						Numero = "33552283534",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 50
					},
					new Telefone{
						Numero = "23817492876",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 51
					},
					new Telefone{
						Numero = "10337473522",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 52
					},
					new Telefone{
						Numero = "67486966826",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 53
					},
					new Telefone{
						Numero = "48404212736",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 54
					},
					new Telefone{
						Numero = "73085490220",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 55
					},
					new Telefone{
						Numero = "58030260686",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 56
					},
					new Telefone{
						Numero = "28366219728",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 57
					},
					new Telefone{
						Numero = "61912764699",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 58
					},
					new Telefone{
						Numero = "62920777745",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 59
					},
					new Telefone{
						Numero = "65687820527",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 60
					},
					new Telefone{
						Numero = "99748525111",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 61
					},
					new Telefone{
						Numero = "81878121358",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 62
					},
					new Telefone{
						Numero = "18664964836",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 63
					},
					new Telefone{
						Numero = "15886510652",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 64
					},
					new Telefone{
						Numero = "93941277652",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 65
					},
					new Telefone{
						Numero = "21384666461",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 66
					},
					new Telefone{
						Numero = "15624864563",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 67
					},
					new Telefone{
						Numero = "23265431478",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 68
					},
					new Telefone{
						Numero = "37162885382",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 69
					},
					new Telefone{
						Numero = "13411455404",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 70
					},
					new Telefone{
						Numero = "85825186056",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 71
					},
					new Telefone{
						Numero = "40662624388",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 72
					},
					new Telefone{
						Numero = "66855383322",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 73
					},
					new Telefone{
						Numero = "38482969654",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 74
					},
					new Telefone{
						Numero = "67586887707",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 75
					},
					new Telefone{
						Numero = "27473587408",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 76
					},
					new Telefone{
						Numero = "70894873629",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 77
					},
					new Telefone{
						Numero = "78117347153",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 78
					},
					new Telefone{
						Numero = "65443163357",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 79
					},
					new Telefone{
						Numero = "07791253533",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 80
					},
					new Telefone{
						Numero = "68150379116",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 81
					},
					new Telefone{
						Numero = "07098160857",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 82
					},
					new Telefone{
						Numero = "72685861317",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 83
					},
					new Telefone{
						Numero = "30496784407",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 84
					},
					new Telefone{
						Numero = "91914686564",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 85
					},
					new Telefone{
						Numero = "67357719193",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 86
					},
					new Telefone{
						Numero = "34468826647",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 87
					},
					new Telefone{
						Numero = "34675354746",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 88
					},
					new Telefone{
						Numero = "60758462846",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 89
					},
					new Telefone{
						Numero = "07971952723",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 90
					},
					new Telefone{
						Numero = "36933508125",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 91
					},
					new Telefone{
						Numero = "26056011004",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 92
					},
					new Telefone{
						Numero = "93439319868",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 93
					},
					new Telefone{
						Numero = "13557652883",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 94
					},
					new Telefone{
						Numero = "15364514266",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 95
					},
					new Telefone{
						Numero = "42399614558",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 96
					},
					new Telefone{
						Numero = "64272037481",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 97
					},
					new Telefone{
						Numero = "82946114450",
						Tipo = TelefoneTipo.Residencial,
						ClienteId = 98
					},
					new Telefone{
						Numero = "86452584411",
						Tipo = TelefoneTipo.Comercial,
						ClienteId = 99
					},
					new Telefone{
						Numero = "62219705509",
						Tipo = TelefoneTipo.Celular,
						ClienteId = 100
					}
				};
				_context.AddRange(Clientes);
				_context.AddRange(Enderecos);
				_context.AddRange(telefones);
				_context.SaveChanges();
            }
        }
    }
}
