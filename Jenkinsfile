pipeline {
    agent any
    environment {
       dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
    }


    stages {
       
          stage('Build') {
                steps {
                   dir("Math.Test"){
                    bat "${dotnet} build"
                   }
                }
            }

            stage('Testing') {
                steps {
                   dir("Math.Test"){
                    bat "${dotnet} test"
                   }
                }
            }

            stage('Cleanimng') {
                steps {
                   dir("Math.Test"){
                    bat "${dotnet} clean"
                   }
                }
            }

    }
}