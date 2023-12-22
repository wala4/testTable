pipeline {
    agent any
    environment {
       dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
    }


    stages {
       
          stage('Build') {
                steps {
                   dir("Math.Tests"){
                    bat "${dotnet} build"
                   }
                }
            }

            stage('Testing') {
                steps {
                   dir("Math.Tests"){
                    bat "${dotnet} test"
                   }
                }
            }

            stage('Cleanimng') {
                steps {
                   dir("Math.Tests"){
                    bat "${dotnet} clean"
                   }
                }
            }

    }
}