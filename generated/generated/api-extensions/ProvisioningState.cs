namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support
{

    /// <summary>Argument completer implementation for ProvisioningState.</summary>
    public partial struct ProvisioningState : System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult> CompleteArgument(System.String commandName, System.String parameterName, System.String wordToComplete, System.Management.Automation.Language.CommandAst commandAst, System.Collections.IDictionary fakeBoundParameters)
        {
            if (System.String.IsNullOrEmpty(wordToComplete) || "Creating".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Creating", "Creating", System.Management.Automation.CompletionResultType.ParameterValue, "Creating");
            }
            if (System.String.IsNullOrEmpty(wordToComplete) || "Updating".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Updating", "Updating", System.Management.Automation.CompletionResultType.ParameterValue, "Updating");
            }
            if (System.String.IsNullOrEmpty(wordToComplete) || "Deleting".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Deleting", "Deleting", System.Management.Automation.CompletionResultType.ParameterValue, "Deleting");
            }
            if (System.String.IsNullOrEmpty(wordToComplete) || "Succeeded".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Succeeded", "Succeeded", System.Management.Automation.CompletionResultType.ParameterValue, "Succeeded");
            }
            if (System.String.IsNullOrEmpty(wordToComplete) || "Failed".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Failed", "Failed", System.Management.Automation.CompletionResultType.ParameterValue, "Failed");
            }
            if (System.String.IsNullOrEmpty(wordToComplete) || "Canceled".StartsWith(wordToComplete, System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new System.Management.Automation.CompletionResult("Canceled", "Canceled", System.Management.Automation.CompletionResultType.ParameterValue, "Canceled");
            }
        }
    }
}