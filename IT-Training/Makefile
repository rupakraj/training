default: compile
	
all: clean compile

compile:
	pdflatex   mvc-syllabus.tex 
	pdflatex   mvc-syllabus.tex
	pdflatex   mvc-syllabus.tex
	 
	
	rm -f *.aux
	rm -f *.log
	rm -f *.lof
	rm -f *.mf
	rm -f *.out
	rm -f *.bbl
	rm -f *.blg
	rm -f *.lot
	rm -f *.toc

	evince mvc-syllabus.pdf

clean:
	rm -f mvc-syllabus.pdf



#clean: 	
	