<?php
$search = htmlspecialchars($_GET["version"]);
$string = file_get_contents("version.txt");
$string = explode("\n", $string); // \n is the character for a line break
if(in_array($search, $string)){
echo $search;
} else {
echo "Version Update";
}
?>
