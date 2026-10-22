public class Solution {
    Dictionary<string, IList<string>> _graph;
    Dictionary<string, string> _emailToName;

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        _graph = new Dictionary<string, IList<string>>();
        _emailToName = new Dictionary<string, string>();

        foreach(var account in accounts){
            string name = account[0];
            string email = account[1];

            if(!_graph.ContainsKey(email)) _graph[email] = new List<string>();
            if(!_emailToName.ContainsKey(email)) _emailToName[email] = name;

            int n = account.Count;
            for(int i = 2; i < n; i++){
                string otherEmail = account[i];

                _graph[email].Add(otherEmail);

                if(!_graph.ContainsKey(otherEmail)) _graph[otherEmail] = new List<string>();
                _graph[otherEmail].Add(email);

                if(!_emailToName.ContainsKey(otherEmail)) _emailToName[otherEmail] = name;
            }
        }

        IList<IList<string>> resultList = new List<IList<string>>();

        HashSet<string> visited = new HashSet<string>();
        foreach(var email in _graph.Keys){
            if(!visited.Contains(email)){
                var emailsList = new List<string>();
                DSF(email, emailsList, visited);

                emailsList.Sort(StringComparer.Ordinal);
                var result = new List<string>(){_emailToName[email]};
                result.AddRange(emailsList);

                resultList.Add(result);
            }
        }

        return resultList;
    }

    private void DSF(string email, IList<string> emailsList, HashSet<string> visited){
        visited.Add(email);
        emailsList.Add(email);

        foreach(var otherEmail in _graph[email]){
            if(!visited.Contains(otherEmail)){
                DSF(otherEmail, emailsList, visited);
            }
        }
    }
}
