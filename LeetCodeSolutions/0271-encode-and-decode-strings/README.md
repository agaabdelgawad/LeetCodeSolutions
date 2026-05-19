<p>Design an algorithm to encode a list of strings to a string. The encoded string is then sent over the network and is decoded back to the original list of strings.</p>

<p>Machine 1 (sender) has the function:</p>
<pre>
String encode(List&lt;String&gt; strs) {
    // ... your code
    return encoded_string;
}
</pre>

<p>Machine 2 (receiver) has the function:</p>
<pre>
List&lt;String&gt; decode(String encoded_string) {
    // ... your code
    return decoded_strs;
}
</pre>

<p>So Machine 1 does:</p>
<pre>
String encoded_string = encode(strs);
</pre>

<p>and Machine 2 does:</p>
<pre>
List&lt;String&gt; decoded_strs = decode(encoded_string);
</pre>

<p><code>decoded_strs</code> in Machine 2 should be the same as the input <code>strs</code> in Machine 1.</p>

<p>Implement the <code>encode</code> and <code>decode</code> methods.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre>
<strong>Input:</strong> strs = ["Hello","World"]
<strong>Output:</strong> ["Hello","World"]
<strong>Explanation:</strong>
Solution solution = new Solution();
String encoded_string = solution.encode(strs);
// Machine 1 ---encoded_string---&gt; Machine 2
List&lt;String&gt; decoded_strs = solution.decode(encoded_string);
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre>
<strong>Input:</strong> strs = [""]
<strong>Output:</strong> [""]
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>0 &lt;= strs.length &lt; 100</code></li>
	<li><code>0 &lt;= strs[i].length &lt; 200</code></li>
	<li><code>strs[i]</code> contains any possible characters out of 256 valid ASCII characters.</li>
</ul>

<p>&nbsp;</p>
<strong>Follow-up:&nbsp;</strong>Could you write a generalized algorithm to work on any possible set of characters?
