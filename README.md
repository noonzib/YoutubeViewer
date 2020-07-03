<h1 align="center">Youtube Viewer</h1>

## 현황

- 입력받은 URL 웹브라우저 출력
- 입력받은 URL ListBox에 임시(?)저장

## TODO

- ListBoxItem 파일형태로 가져와야될듯
- ListBoxItem 저장 -> 파일에 저장
- ListBoxItem 정렬 -> 이건 따로 해야될거 같음
- ListBoxItem 삭제
- ListboxItem 이름수정
- List를 파일로 저장하고 URL이랑 이름이랑 따로 저장해서 불러오고 이름 초기값을 URL로 그리고 출력할때 이름만 불러옴 그리고 눌러서 링크하면 URL을 가져옴
- 왼쪽 하단에 현재 재생되고 있는 영상 이름 출력

~~~ xml
<data>
	<Name>URL</Name>
	<URL>http://asdfasdf.com</URL>
</data> 
~~~ 

## 그럼 공부해야되는게 
- 데이터를 파일에서 가져와서 출력하기, 입력받은 값 파일에 저장, 파일의 값 수정, 삭제, 정렬