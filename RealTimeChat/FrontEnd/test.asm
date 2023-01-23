.MODEL SMALL
.STACK 100H	
.DATA
number_prompt  db  "Please input a number (32 - 126): ",0
char_prompt    db  "Please input a character: ",0
out_msg1       db  "The character is: ",0
out_msg2       db  "The ASCII code is: ",0
query_msg      db  "Do you want to quit (Y/N): ",0

.586
.CODE
INCLUDE io.mac
        .STARTUP
read_char:
      PutStr  number_prompt ; request a number input
      getint DX             ; read number in DX
	nwln
	putstr out_msg1
	mov AH, 02h          ; print the character in DX
	int 21h
	nwln
	putstr Char_prompt   ; request a char input
	nwln
	mov AH, 01h          ; read a char in AL
	int 21h
	nwln
	putstr out_msg2
	mov AH,0             ; mov 0's to the upper byte in AX
	putint AX            ; print the value in AL (AX) 
	nwln
	putstr query_msg     ; query user whether to terminate
	GetCh   AL           ; read response using read char macro
      nwln
      cmp     AL,'Y'
	cmp     AL, 'y'      ; if response is not 'Y' or 'y'
      jne     read_char    ; start over
done:                        ; otherwise, terminate program
     .EXIT
END