<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="HospitalManagementSystemASPNETCORE_0"></a>Hospital-Management-System-ASPNETCORE</h1>
<p class="has-line-data" data-line-start="1" data-line-end="2">An HMS with <a href="http://ASP.NET">ASP.NET</a> CORE</p>
<p class="has-line-data" data-line-start="3" data-line-end="8">Versões:<br>
<a href="http://ASP.NET">ASP.NET</a> Core 6.0<br>
Microsoft.EntityFrameworkCore.SqlServer&quot; Version=“6.0.1”<br>
Microsoft.EntityFrameworkCore.Tools&quot; Version=“6.0.1”<br>
Microsoft.VisualStudio.Web.CodeGeneration.Design&quot; Version=“6.0.1”</p>
<p class="has-line-data" data-line-start="9" data-line-end="11">tags:<br>
Domain Driven Design, Migrations, Viewmodel, DataAnnotation, AutoMapper, Entity Framework, Identity, Dependency Injection, Scaffolding</p>
<p class="has-line-data" data-line-start="15" data-line-end="18">Problemas na hora da construcao do projeto:<br>
1- Erro no scaffold -&gt; corrigido gerando o scaffold em outro projeto e copiando para o projeto incial<br>
2- erro na renderização das view components -&gt;  Corrigido com a utilizacao de @await Component.InvokeAsync(“EstadoCritico”, new {}) ao inves do tag &lt;vc:estado-critico&gt;&lt;/vc:estado-critico&gt;</p>
