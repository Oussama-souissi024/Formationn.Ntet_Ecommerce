namespace Formationn_Ecommerce.Core.Interfaces.External
{
    public interface IEmailTemplateService
    {
        /// <summary>
        /// Rend un template HTML avec les valeurs de remplacement spécifiées
        /// </summary>
        /// <param name="templateName">Nom du template (sans extension)</param>
        /// <param name="replacements">Dictionnaire des valeurs à remplacer (clé = placeholder, valeur = remplacement)</param>
        /// <returns>Le contenu HTML final avec les remplacements effectués</returns>
        Task<string> RenderTemplateAsync(string templateName, Dictionary<string, string> replacements);
    }
}
