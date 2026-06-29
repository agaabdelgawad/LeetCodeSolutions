public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();

        string[] dirs = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

        foreach (var dir in dirs){
            if(dir == ".."){
                if(stack.Count > 0) stack.Pop();
            }
            else if(dir != ".") stack.Push(dir);
        }

        string[] stackPath = stack.ToArray();
        Array.Reverse(stackPath);

        StringBuilder sb = new StringBuilder();
        foreach(var dir in stackPath){
            sb.Append($"/{dir}");
        }

        return sb.Length == 0 ? "/" : sb.ToString();
    }
}
